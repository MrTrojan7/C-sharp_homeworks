using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    /// <summary>
    /// Generalized class Point <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">type</typeparam>
    class Point<T>
    {
        protected T x;
        protected T y;
        protected T z;

        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }
        public T Z
        {
            get { return z; }
            set { z = value; }
        }
        public Point(T x, T y, T z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Point()
        {
            X = default(T);
            Y = default(T);
            Z = default(T);
        }
        public void Print()
        {
            Console.WriteLine("Point x = " + X);
            Console.WriteLine("Point y = " + Y);
            Console.WriteLine("Point z = " + Z);
        }
    }
}