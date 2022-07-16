using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_1
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;
        private int h = 10;
        private int w = 15;
        static Random rand = new Random();
        ToolTip toolTip1 = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            InitB();
        }

        public void InitB()
        {
            Button [,] buttons = new Button[4, 4];
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Parent = this;
                    buttons[i, j].Location = new Point(i * 50, j * 50);
                    buttons[i, j].Size = new Size(40, 40);
                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Text = "btn " + i + "." + j;
                    buttons[i, j].BackColor = RandomColor();
                    toolTip1.SetToolTip(buttons[i, j], "my_button " + i + j);
                    buttons[i, j].Click += RemoveButton;
                    this.Controls.Add(buttons[i, j]);
                }
            }
            //button1_Click(buttons[0, 0], )
        }
        private Color RandomColor()
        {
            return Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RemoveButton(object sender, EventArgs e)
        {
            var button = sender as Button;

            button.Visible = false;
            this.Controls.Remove(button);
        }
    }
}
