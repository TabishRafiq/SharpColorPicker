namespace SharpColorPicker
{
    partial class SharpColorPicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.H_Slider = new System.Windows.Forms.PictureBox();
            this.SV_Slider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.H_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // H_Slider
            // 
            this.H_Slider.Location = new System.Drawing.Point(0, 180);
            this.H_Slider.Name = "H_Slider";
            this.H_Slider.Size = new System.Drawing.Size(213, 16);
            this.H_Slider.TabIndex = 3;
            this.H_Slider.TabStop = false;
            this.H_Slider.Paint += new System.Windows.Forms.PaintEventHandler(this.H_Slider_Paint);
            this.H_Slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.H_Slider_MouseMove);
            // 
            // SV_Slider
            // 
            this.SV_Slider.Location = new System.Drawing.Point(0, 0);
            this.SV_Slider.Name = "SV_Slider";
            this.SV_Slider.Size = new System.Drawing.Size(213, 165);
            this.SV_Slider.TabIndex = 2;
            this.SV_Slider.TabStop = false;
            this.SV_Slider.Paint += new System.Windows.Forms.PaintEventHandler(this.SV_Slider_Paint);
            this.SV_Slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SV_Slider_MouseMove);
            // 
            // SharpColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.H_Slider);
            this.Controls.Add(this.SV_Slider);
            this.Name = "SharpColorPicker";
            this.Size = new System.Drawing.Size(213, 196);
            ((System.ComponentModel.ISupportInitialize)(this.H_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox H_Slider;
        private System.Windows.Forms.PictureBox SV_Slider;
    }
}
