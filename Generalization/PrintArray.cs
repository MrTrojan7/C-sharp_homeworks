using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    /// <summary>
    /// Print_Array<![CDATA[<T>]]>
    /// Print array in console
    /// </summary>
    class PrintArray 
    {
        /// <summary>
        /// Static method
        /// </summary>
        /// <typeparam name="T">generalization type</typeparam>
        /// <param name="arr">array of generalization type</param>
        public static void Print_Array<T>(ref T[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + "\t");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
