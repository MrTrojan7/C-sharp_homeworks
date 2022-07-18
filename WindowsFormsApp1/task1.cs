﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_App1
{
    public class Form2 : Form
    {
        private const int maxCount = 256;
        private int it = 0;
        private Button[] button = new Button[256];
        private int x1;
        private int y1;
        private int x;
        private int y;
        private int x_mouse_down;
        private int y_mouse_down;
        private int width;
        private int height;
        private int flag_lbtn_down = 0;
        private int flag_create_wnd = 0;
        private IContainer components = (IContainer)null;

        public Form2() => this.InitializeComponent();

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            this.flag_lbtn_down = 1;
            this.x_mouse_down = e.X;
            this.y_mouse_down = e.Y;
            this.x = e.X;
            this.y = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            this.x1 = e.X;
            this.y1 = e.Y;
            if (this.flag_lbtn_down != 1)
                return;
            this.width = this.x1 - this.x_mouse_down;
            this.height = this.y1 - this.y_mouse_down;
            if (this.width <= 0 || this.height <= 0)
            {
                if (this.width > 0 && this.height < 0)
                {
                    this.y = this.y1;
                    this.height = Math.Abs(this.height);
                }
                else if (this.width < 0 && this.height > 0)
                {
                    this.x = this.x1;
                    this.width = Math.Abs(this.width);
                }
                else if (this.width < 0 && this.height < 0)
                {
                    this.x = this.x1;
                    this.y = this.y1;
                    this.height = Math.Abs(this.height);
                    this.width = Math.Abs(this.width);
                }
            }
            if (this.flag_create_wnd == 0)
            {
                this.button[this.it] = new Button();
                this.SuspendLayout();
                this.button[this.it].Name = "button" + (object)this.it;
                this.button[this.it].Text = "button" + (object)this.it;
                this.button[this.it].TabIndex = 0;
                this.button[this.it].UseVisualStyleBackColor = true;
                this.button[this.it].Location = new Point(this.x, this.y);
                this.button[this.it].Size = new Size(this.width, this.height);
                this.button[this.it].Visible = true;
                this.flag_create_wnd = 1;
                this.Controls.Add((Control)this.button[this.it]);
            }
            else
            {
                this.button[this.it].Location = new Point(this.x, this.y);
                this.button[this.it].Size = new Size(this.width, this.height);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            this.flag_lbtn_down = 0;
            this.flag_create_wnd = 0;
            if (this.width < 20 || this.height < 20)
            {
                int num = (int)MessageBox.Show("Кнопка слишком маленького размера!", "Error");
                this.button[this.it].Dispose();
            }
            else
            {
                this.x1 = e.X;
                this.y1 = e.Y;
                this.width = this.x1 - this.x_mouse_down;
                this.height = this.y1 - this.y_mouse_down;
                if (this.width <= 0 || this.height <= 0)
                {
                    if (this.width > 0 && this.height < 0)
                    {
                        this.y = this.y1;
                        this.height = Math.Abs(this.height);
                    }
                    else if (this.width < 0 && this.height > 0)
                    {
                        this.x = this.x1;
                        this.width = Math.Abs(this.width);
                    }
                    else if (this.width < 0 && this.height < 0)
                    {
                        this.x = this.x1;
                        this.y = this.y1;
                        this.height = Math.Abs(this.height);
                        this.width = Math.Abs(this.width);
                    }
                }
                this.button[this.it].Location = new Point(this.x, this.y);
                this.button[this.it].Size = new Size(this.width, this.height);
                ++this.it;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(705, 507);
            this.Name = nameof(Form2);
            this.Text = "Рисование кнопками";
            this.MouseDown += new MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);
        }
    }
}
