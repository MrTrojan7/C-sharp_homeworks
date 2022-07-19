using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        DateTime time_end = new DateTime(2022, 12, 31, 23, 59, 59); // New Year
        TimeSpan time_span = new TimeSpan();
        private static Timer vTimer = new Timer();
        private void ShowTime(object vObj, EventArgs e)
        {
            time_span = time_end - DateTime.Now;
            this.TimeButton.Text = time_span.ToString();
        }
        public Form5()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowTime);
            vTimer.Interval = 1000;
            vTimer.Start();
        }
    }
}
