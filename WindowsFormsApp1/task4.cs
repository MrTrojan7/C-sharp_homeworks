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
    public partial class task4 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        uint time = 0;
        public task4()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 15; // https://docs.microsoft.com/ru-ru/dotnet/api/system.timers.timer.interval?view=net-6.0
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            time += 15;
            this.Text = time.ToString();
        }
    }
}
