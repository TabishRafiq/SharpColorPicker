﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SharpColorPicker
{
    /// <summary>
    /// Represents the color picker component.
    /// </summary>
    [DefaultProperty("Color")]
    [DefaultEvent("ColorChanged")]
    public partial class SharpColorPicker : UserControl
    {

        public SharpColorPicker()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //hue = Color.Red;
        }

        /// <summary>
        /// Defines the Color.
        /// </summary>
        private Color color = Color.White;

        /// <summary>
        /// Defines the hue of SV slider.
        /// </summary>
        private Color hue = Color.Red;

        /// <summary>
        /// Defines the pointer size.
        /// </summary>
        private static int pointerSize = 10;

        /// <summary>
        /// Rectangle for SV pointer.
        /// </summary>
        private RectangleF rec_SV = new RectangleF(0, 0, pointerSize, pointerSize);

        /// <summary>
        /// Rectangle for H pointer.
        /// </summary>
        private RectangleF rec_H = new RectangleF(0, 7.5f, pointerSize, pointerSize);

        /// <summary>
        /// Specifies the value change handler.
        /// </summary>
        public event EventHandler ColorChanged;

        /// <summary>
        /// Gets or sets color.
        /// </summary>
        [Description("Selected color")]
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {               
                SetColor(value);
                Refresh();
            }
        }

        private void UpdateColor()
        {
            Color oldcolor = color;

            double s = (rec_SV.X / SV_Slider.Width);
            double v = ((SV_Slider.Height - rec_SV.Y) / SV_Slider.Height);
            double h = (rec_H.X / SV_Slider.Width) * 360;

            color = HSVRGBConverter.ColorFromHSV(h, s, v);

            if (oldcolor != color)
                ColorChanged?.Invoke(this, null);

        }

        private void SetColor(Color _color)
        {
            Color oldcolor = color;

            double h, s, v;

            HSVRGBConverter.ColorToHSV(_color, out h, out s, out v);

            rec_SV.X = (float)(s * SV_Slider.Width);
            rec_SV.Y = (float)(SV_Slider.Height - (v * SV_Slider.Height));

            rec_H.X = (float)((h / 360) * SV_Slider.Width);

            hue = HSVRGBConverter.ColorFromHSV((rec_H.X / H_Slider.Width) * 360, 1, 1);
            color = _color;

            SV_Slider.Refresh();
            H_Slider.Refresh();

            if (oldcolor != color)
                ColorChanged?.Invoke(this, null);
        }

        private void SV_Slider_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (LinearGradientBrush br = new LinearGradientBrush(new Rectangle(0, 0, SV_Slider.Width, SV_Slider.Height), Color.White, hue, LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(br, SV_Slider.ClientRectangle);

            using (LinearGradientBrush br = new LinearGradientBrush(new Rectangle(0, 0, SV_Slider.Width, SV_Slider.Height), Color.FromArgb(0, 0, 0, 0), Color.Black, LinearGradientMode.Vertical))
                e.Graphics.FillRectangle(br, SV_Slider.ClientRectangle);

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(30, 0, 0, 0), 2), 0, 0, SV_Slider.Width, SV_Slider.Height);

            DrawPointer(e.Graphics, rec_SV);
        }

        private void SV_Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X < 0)
                    rec_SV.X = 0;
                else if (e.X > SV_Slider.Width)
                    rec_SV.X = SV_Slider.Width;
                else
                    rec_SV.X = e.X;

                if (e.Y < 0)
                    rec_SV.Y = 0;
                else if (e.Y > SV_Slider.Height)
                    rec_SV.Y = SV_Slider.Height;
                else
                    rec_SV.Y = e.Y;

                UpdateColor();
                SV_Slider.Refresh();
            }
        }

        private void H_Slider_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            using (Brush rainbow_brush = RainbowBrush(new Point(0, H_Slider.Top), new Point(H_Slider.Width, H_Slider.Top)))
            {
                e.Graphics.FillRectangle(rainbow_brush, H_Slider.ClientRectangle);
            }
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(30, 0, 0, 0), 2), 0, 0, H_Slider.Width + 1, H_Slider.Height + 1);

            DrawPointer(e.Graphics, rec_H);
        }

        private void H_Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                if (e.X < 0)
                    rec_H.X = 0;
                else if (e.X > H_Slider.Width)
                    rec_H.X = H_Slider.Width;
                else
                    rec_H.X = e.X;

                hue = HSVRGBConverter.ColorFromHSV((rec_H.X / H_Slider.Width) * 360, 1, 1);

                UpdateColor();

                SV_Slider.Refresh();
                H_Slider.Refresh();
            }
        }

        private void DrawPointer(Graphics g, RectangleF r)
        {
            g.DrawEllipse(new Pen(Color.FromArgb(50, 0, 0, 0), 5), r.X - (r.Width/2), r.Y - (r.Height / 2), r.Width, r.Height);
            g.DrawEllipse(new Pen(Color.White, 3), r.X - (r.Width / 2), r.Y - (r.Height / 2), r.Width, r.Height);
        }

        public LinearGradientBrush RainbowBrush(Point point1, Point point2)
        {
            LinearGradientBrush rainbow_brush = new LinearGradientBrush(point1, point2, Color.Red, Color.Red);

            ColorBlend color_blend = new ColorBlend();
            color_blend.Colors = new Color[]
                { Color.Red, Color.Yellow, Color.Lime, Color.Aqua,  Color.Blue, Color.Fuchsia, Color.Red };
            color_blend.Positions = new float[]
                { 0, 1 / 6f, 2 / 6f, 3 / 6f, 4 / 6f, 5 / 6f, 1 };
            rainbow_brush.InterpolationColors = color_blend;

            return rainbow_brush;
        }
    }
}
