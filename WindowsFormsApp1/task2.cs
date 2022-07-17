using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms_App1
{
    public class Form3 : Form
    {
        private int x_btn;
        private int y_btn;
        private int width_btn;
        private int height_btn;
        private int sizeX;
        private int sizeY;
        private Random r = new Random();
        private int randX;
        private int randY;
        private IContainer components = (IContainer)null;
        private Button button1;

        public Form3()
        {
            this.InitializeComponent();
            this.x_btn = this.button1.Location.X;
            this.y_btn = this.button1.Location.Y;
            this.width_btn = this.button1.Width;
            this.height_btn = this.button1.Height;
            this.sizeX = this.Size.Width;
            this.sizeY = this.Size.Height;
            this.randX = this.sizeX - this.button1.Width - 20;
            this.randY = this.sizeY - this.button1.Height - 20;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= this.x_btn - 1 && e.X <= this.x_btn + this.width_btn && e.Y >= this.y_btn - 1 && e.Y <= this.y_btn + this.height_btn)
            {
                this.x_btn = this.r.Next(0, this.randX);
                this.y_btn = this.r.Next(0, this.randY);
            }
            this.button1.Location = new Point(this.x_btn, this.y_btn);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.x_btn = this.r.Next(0, this.randX);
            this.y_btn = this.r.Next(0, this.randY);
            this.button1.Location = new Point(this.x_btn, this.y_btn);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.SuspendLayout();
            this.button1.Location = new Point(262, 172);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseMove += new MouseEventHandler(this.button1_MouseMove);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(696, 516);
            this.Controls.Add((Control)this.button1);
            this.Name = nameof(Form3);
            this.Text = nameof(Form3);
            this.MouseMove += new MouseEventHandler(this.Form3_MouseMove);
            this.ResumeLayout(false);
        }
    }
}
