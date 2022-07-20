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
    public partial class Form6 : Form
    {
        private Color[] myColor = new Color[] // version 1
        { 
            Color.Black, Color.Red, Color.Yellow, Color.Green,
            Color.Azure, Color.Blue, Color.Pink, Color.White 
        };

        private static Timer vTimer = new Timer(); // all versions
        private static short count = 0; // version 1
        private static Random rnd = new Random(); //version 2
        private void ShowColor(object vObj, EventArgs e) // version 1
        {
            if (count >= myColor.Length)
            {
                count = 0;
            }
            this.BackColor = myColor[count];
            ++count;
        }

        private void ShowColor_v2(object vObj, EventArgs e) // version 2
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        public Form6()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowColor); // replace the function (version 1/2)
            vTimer.Interval = 500; 
            vTimer.Start();
        }
    }
}
