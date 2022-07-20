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
    public partial class Form7 : Form
    {
        private static Timer vTimer = new Timer();
        private static TimeSpan time_span = new TimeSpan();
        private static DateTime date_end;
        private bool flag_of_move = false;
        private int count_of_click = 0;
        private int max_cnt = 0;

        /// <summary>
        /// show time on button 
        /// if time is out - end of round
        /// </summary>
        private void ShowTime(object vObj, EventArgs e)
        {
            time_span = date_end - DateTime.Now;
            this.buttonToPress.Text = time_span.Seconds.ToString();
            if (time_span.TotalSeconds < 0)
            {
                EndOfRound();
            }
        }
        /// <summary>
        /// end of round
        /// show results
        /// </summary>
        private void EndOfRound()
        {
            vTimer.Stop();
            if (count_of_click > max_cnt)
            {
                max_cnt = count_of_click;
            }
            this.buttonToPress.Text = "End! Your count of click: " + count_of_click.ToString() +
                ". Max count: " + max_cnt.ToString() +
                ".\nTake the mouse off the button and hover again to start a new round";
            count_of_click = 0;
        }
        /// <summary>
        /// constructor
        /// </summary>
        public Form7()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowTime);
            vTimer.Interval = 1000;
        }

        /// <summary>
        /// Start round
        /// </summary>
        private void buttonToPress_MouseMove(object sender, MouseEventArgs e)
        {
            if (!flag_of_move)
            {
                date_end = DateTime.Now.AddSeconds(20);
                this.buttonToPress.Text = "Start now!";
                vTimer.Start();
                flag_of_move = true;
            }
        }

        /// <summary>
        /// Counter of clicks (if round is start)
        /// </summary>
        private void buttonToPress_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag_of_move)
            {
                ++count_of_click;
            }
        }

        /// <summary>
        /// round end logic (if time not out - send message "try again")
        /// </summary>
        private void buttonToPress_MouseLeave(object sender, EventArgs e)
        {
            if (vTimer.Enabled)
            {
                this.buttonToPress.Text = "You took the mouse off the button.\nTry again";
            }
            if (flag_of_move)
            {
                flag_of_move = false;
            }
            vTimer.Stop();
        }
    }
}
