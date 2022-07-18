using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private Button button;
        Point pnt;

        public Form3()
        {
            InitializeComponent();
            
            while (true)
            {
                this.button.Location = pnt;
                pnt.X += 10;
                Thread.Sleep(200);
            }
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(705, 507);
            this.Name = nameof(Form3);
            this.Text = "Рисование кнопками v2";
            this.ResumeLayout(false);
            this.button = new Button();
            this.button.Height = 40;
            pnt = new Point(20, 50);
            this.button.Location = pnt;
            this.button.Name = "button1";
            this.button.Size = new Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "button1";
            this.button.Width = 100;
            this.button.Parent = this;
            this.button.UseVisualStyleBackColor = true;
        }
    }
}
