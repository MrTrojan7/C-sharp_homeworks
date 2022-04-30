using System;

namespace test
{
    class Point
    {
        private int x;
        private int y;

        public Point() : this(0, 0) // делегирование
        { }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 10 && value < 100)
                {
                    y = value;
                }
                else
                {
                    y = 0;
                }
            }
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
        public static int operator +(Point a, int b)
        {
            return a.X + a.Y + b;
        }
        public static int operator +(int num, Point obj)
        {
            return num + obj.X + obj.Y;
        }
        public static int operator -(int num, Point obj)
        {
            return num - obj.X - obj.Y;
        }
        public static Point operator -(Point obj, int num)
        {
            return new Point(obj.X - num, obj.Y - num);
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator *(Point a, Point b)
        {
            return new Point(a.X * b.X, a.Y * b.Y);
        }
        public static int operator *(Point a, int b)
        {
            return a.X * a.Y * b;
        }
        public static int operator *(int num, Point obj)
        {
            return num * obj.X * obj.Y;
        }
        public static implicit operator int(Point obj)
        {
            return (obj.x * obj.y) / 2;
        }

        public static bool operator ==(Point obj1, Point obj2)
        {
            if ((obj1.X == obj2.X) && (obj1.Y == obj2.Y))
                return true;
            else
                return false;
        }
        public static bool operator !=(Point obj1, Point obj2)
        {
            if (obj1 == obj2)
                return false;
            else
                return true;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Point obj = new Point(100, 50);
                Point obj2 = new Point(4, 6);

                // реализовать соответствующие перегрузки 
                int rez1 = 10 + obj;

                Point rez2 = obj - 10;

                Point rez3 = obj * obj2;

                rez1 = obj * 5;

                int rezult = obj2; // преобразование типов

                if (obj == obj2)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("No");
                }




            }
        }
    }
}
