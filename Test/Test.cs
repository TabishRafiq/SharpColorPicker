using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            sharpColorPicker1.Color = Color.FromArgb(255, 174, 231, 241);
        }

        private void sharpColorPicker1_ColorChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = sharpColorPicker1.Color;
            string hex = "#" + sharpColorPicker1.Color.R.ToString("X2") + sharpColorPicker1.Color.G.ToString("X2") + sharpColorPicker1.Color.B.ToString("X2");
            textBox_hex.Text = hex;
        }

        private void textBox_hex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
