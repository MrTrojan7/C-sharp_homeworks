using System.Drawing;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        private Labirint l;
        private int sizeX;
        private int sizeY;
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
            Health();
        }

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            this.sizeX = 40 + 10; // wight (+ 10 for info in right part of the window)
            this.sizeY = 20; // height

            this.Width = sizeX * 16 + 16;
            this.Height = sizeY * 16 + 40;
            this.health.Location = new Point(this.Width - (this.Width / 7), this.Height / 4);
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame() 
        {
            l = new Labirint(this, (sizeX - 10), sizeY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    l.MovingPers(0, -1);
                    break;
                case Keys.Up:
                    l.MovingPers(-1, 0);
                    break;
                case Keys.Right:
                    l.MovingPers(0, 1);
                    break;
                case Keys.Down:
                    l.MovingPers(1, 0);
                    break;
                case Keys.Escape:
                    if(MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        System.Environment.Exit(0);
                    break;
                default:
                    break;

            }
            Health();
            if (l.IsWin())
            {
                MessageBox.Show("Congratulations! You are winner!");
                System.Environment.Exit(0);
            }
        }

        private void Health()
        {
            this.health.Text = l._health.ToString();
        }
    }
}
