namespace Test
{
    partial class Test
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_hex = new System.Windows.Forms.TextBox();
            this.sharpColorPicker1 = new SharpColorPicker.SharpColorPicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_hex
            // 
            this.textBox_hex.BackColor = System.Drawing.Color.White;
            this.textBox_hex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hex.Location = new System.Drawing.Point(24, 230);
            this.textBox_hex.Name = "textBox_hex";
            this.textBox_hex.Size = new System.Drawing.Size(145, 25);
            this.textBox_hex.TabIndex = 3;
            this.textBox_hex.TextChanged += new System.EventHandler(this.textBox_hex_TextChanged);
            // 
            // sharpColorPicker1
            // 
            this.sharpColorPicker1.BackColor = System.Drawing.Color.Transparent;
            this.sharpColorPicker1.Color = System.Drawing.Color.Black;
            this.sharpColorPicker1.Location = new System.Drawing.Point(24, 17);
            this.sharpColorPicker1.Name = "sharpColorPicker1";
            this.sharpColorPicker1.Size = new System.Drawing.Size(213, 196);
            this.sharpColorPicker1.TabIndex = 4;
            this.sharpColorPicker1.ColorChanged += new System.EventHandler(this.sharpColorPicker1_ColorChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(188, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 23);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(259, 270);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sharpColorPicker1);
            this.Controls.Add(this.textBox_hex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.ShowIcon = false;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_hex;
        private SharpColorPicker.SharpColorPicker sharpColorPicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

