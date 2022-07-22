using System.Drawing;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        Labirint l;
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 50;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame() 
        {
            l = new Labirint(this, 40, 20);
            l.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.l.maze[l.smileY, l.smileX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                this.l.InitMazeObject(l.smileY, l.smileX);
                this.l.images[l.smileY, l.smileX].Visible = true;
                this.l.maze[l.smileY, ++l.smileX] = new MazeObject(MazeObject.MazeObjectType.CHAR);
                this.l.InitMazeObject(l.smileY, l.smileX);
                this.l.images[l.smileY, l.smileX].Visible = true;
                //this.l.Show();
            }
        }
    }
}
