using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        // создаём таймер
        //private static Timer vTimer = new Timer();
        private System.Windows.Forms.Label labelTime;
        // Обработчик тика для таймера
        private void ShowTime(object vObj, EventArgs e)
        {
            // преобразование к строке
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        public Form3()
        {
            InitializeComponent();
            // преобразование к строке
            //labelTime.Text = DateTime.Now.ToLongTimeString();
            //// закрепление обработчика
            //vTimer.Tick += new EventHandler(ShowTime);
            //// установка интервала времени
            //vTimer.Interval = 500;
            //// стартуем таймер
            //vTimer.Start();
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
        }
    }
}
