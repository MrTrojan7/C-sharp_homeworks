using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class task3 : Form
    {
        Point templocation = new Point(37, 62);

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public task3()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 50;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.driving_button.Location = templocation;
            templocation.X += 2;
        }
    }
}
