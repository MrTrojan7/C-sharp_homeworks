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
        private Color[] myColor = new Color[] 
        { Color.Black, Color.Red, Color.Yellow, Color.Green,
        Color.Azure, Color.Blue, Color.Pink, Color.White };
        private static Timer vTimer = new Timer();
        private static short count = 0;
        private void ShowColor(object vObj, EventArgs e)
        {
            if (count >= myColor.Length)
            {
                count = 0;
            }
            this.BackColor = myColor[count];
            ++count;
        }
        public Form6()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowColor);
            vTimer.Interval = 500;
            vTimer.Start();
        }
    }
}
