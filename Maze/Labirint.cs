﻿using System;
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
        private static Random r = new Random();
        private Form parent;

        public short _health = 100;
        public int player_money = 0;
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
                    if (r.Next(0, 5) == 0)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // в 1 случае из 50 - кладём денежку
                    if (r.Next(50) == 0)
                    {
                        current = MazeObject.MazeObjectType.MONEY;
                    }

                    // в 1 случае из 150 - размещаем врага
                    if (r.Next(75) == 0)
                    {
                        current = MazeObject.MazeObjectType.ENEMY;
                    }

                    // в 1 случае из 200 - кладём аптечку
                    if (r.Next(200) == 0)
                    {
                        current = MazeObject.MazeObjectType.FIRST_AID_KIT;
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

                    switch (current)
                    {
                        case MazeObject.MazeObjectType.HALL:
                            ++MazeObject.countOFMazeObjects[(int)MazeObject.MazeObjectType.HALL];
                            break;
                        case MazeObject.MazeObjectType.WALL:
                            ++MazeObject.countOFMazeObjects[(int)MazeObject.MazeObjectType.WALL];
                            break;
                        case MazeObject.MazeObjectType.MONEY:
                            ++MazeObject.countOFMazeObjects[(int)MazeObject.MazeObjectType.MONEY];
                            break;
                        case MazeObject.MazeObjectType.ENEMY:
                            ++MazeObject.countOFMazeObjects[(int)MazeObject.MazeObjectType.ENEMY];
                            break;
                        //case MazeObject.MazeObjectType.CHAR:
                        //    break;
                        case MazeObject.MazeObjectType.FIRST_AID_KIT:
                            ++MazeObject.countOFMazeObjects[(int)MazeObject.MazeObjectType.FIRST_AID_KIT];
                            break;
                        default:
                            break;
                    }
                    lbl[y, x] = new Label();
                    InitObject(y, x, current);
                }
            }
        }

        private void InitObject(int y, int x, MazeObject.MazeObjectType mazeObject)
        {
            maze[y, x] = new MazeObject(mazeObject);
            lbl[y, x].Location = new Point(x * 16, y * 16);
            lbl[y, x].Parent = parent;
            lbl[y, x].Width = 16;
            lbl[y, x].Height = 16;
            lbl[y, x].BackgroundImage = MazeObject.images[(int)maze[y, x].type];
            lbl[y, x].Visible = true;
        }

        public void MovingPers(int y, int x)
        {
            if (IsPossibleMoving(y, x))
            {
                switch (maze[(coordY + y), (coordX + x)].type)
                {
                    case MazeObject.MazeObjectType.MONEY:
                        MovingToMONEY(y, x);
                        break;
                    case MazeObject.MazeObjectType.ENEMY:
                        MovingToENEMY(y, x);
                        break;
                    case MazeObject.MazeObjectType.FIRST_AID_KIT:
                        MovingToFIRST_AID_KIT(y, x);
                        break;
                    default:
                        break;
                }
                InitObject(coordY, coordX, MazeObject.MazeObjectType.HALL);
                InitObject((coordY += y), (coordX += x), MazeObject.MazeObjectType.CHAR);
            }
        }

        private bool IsPossibleMoving(int y, int x)
        {
            if ((coordX + x) < 0 || (maze[(coordY + y), (coordX + x)].type == MazeObject.MazeObjectType.WALL))
            {
                return false;
            }
            return true;
        }

        private void MovingToFIRST_AID_KIT(int y, int x)
        {
            _health += (short)r.Next(15, 25);
            if (_health > 100)
            {
                _health = 100;
            }
        }

        private void MovingToENEMY(int y, int x)
        {
            _health -= (short)r.Next(15, 25);
            if (_health <= 0)
            {
                _health = 0;
                MessageBox.Show("GameOver. Health = 0");
                System.Environment.Exit(0);
            }
        }

        private void MovingToMONEY(int y, int x)
        {
            ++player_money;
            if (player_money == MazeObject.countOFMazeObjects[(int)MazeObject.MazeObjectType.MONEY])
            {
                MessageBox.Show("Congratulations! You have collected all coins!");
                System.Environment.Exit(0);
            }
        }

        public void IsFoundExit()
        {
            if (maze[height - 3, width - 1].type == MazeObject.MazeObjectType.CHAR)
            {
                MessageBox.Show("Win! Exit found");
                System.Environment.Exit(0);
            }
        }
    }
}
