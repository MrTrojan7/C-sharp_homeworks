using System;
using System.Windows.Forms;
using System.Drawing;

namespace Maze
{
    class Labirint
    {
        private int height; // высота лабиринта (количество строк)
        private int width; // ширина лабиринта (количество столбцов в каждой строке)

        private MazeObject[,] maze;
        private Label[,] lbl;
        //public PictureBox[,] images;

        private static Random r = new Random();
        private Form parent;
        public int coordX = 0;
        public int coordY = 2;

        public Labirint(Form parent, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.parent = parent;
            maze = new MazeObject[height, width];
            lbl = new Label[height, width];

            Generate();
        }

        private void Generate()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    MazeObject.MazeObjectType current = MazeObject.MazeObjectType.HALL;

                    // в 1 случае из 5 - ставим стену
                    if (r.Next(5) == 0)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // в 1 случае из 50 - кладём денежку
                    if (r.Next(50) == 0)
                    {
                        current = MazeObject.MazeObjectType.MEDAL;
                    }

                    // в 1 случае из 150 - размещаем врага
                    if (r.Next(150) == 0)
                    {
                        current = MazeObject.MazeObjectType.ENEMY;
                    }

                    // стены по периметру обязательны
                    if (y == 0 || x == 0 || y == height - 1 | x == width - 1)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // наш персонажик
                    if (x == coordX && y == coordY)
                    {
                        current = MazeObject.MazeObjectType.CHAR;
                    }

                    // есть выход, и соседняя ячейка справа всегда свободна
                    if (x == coordX + 1 && y == coordY || x == width - 1 && y == height - 3)
                    {
                        current = MazeObject.MazeObjectType.HALL;
                    }
                    lbl[y, x] = new Label();
                    maze[y, x] = new MazeObject(current);
                    InitObject(y, x);
                }
            }
        }

        private void InitObject(int y, int x)
        {
            lbl[y, x].Location = new Point(x * 16, y * 16);
            lbl[y, x].Parent = parent;
            lbl[y, x].Width = 16;
            lbl[y, x].Height = 16;
            lbl[y, x].BackgroundImage = MazeObject.images[(int)maze[y, x].type];
            lbl[y, x].Visible = true;
        }

        public void MovingPers(int y, int x)
        {
            if (!IsPossibleMoving(y, x))
            {
                return;
            }
            maze[coordY, coordX] = new MazeObject(MazeObject.MazeObjectType.HALL);
            InitObject(coordY, coordX);
            maze[(coordY += y), (coordX += x)] = new MazeObject(MazeObject.MazeObjectType.CHAR);
            InitObject(coordY, coordX);
        }

        private bool IsPossibleMoving(int y, int x)
        {
            if ((maze[(coordY + y), (coordX + x)].type == MazeObject.MazeObjectType.WALL) || (coordY + y) < 0)
            {
                return false;
            }
            return true;
        }

        public bool IsWin()
        {
            if (MazeObject.MazeObjectType.CHAR == maze[height - 3, width - 1].type)
            {
                return true;
            }
            return false;
        }
    }
}
