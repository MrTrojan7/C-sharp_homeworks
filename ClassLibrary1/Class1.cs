using System;
using System.Runtime.InteropServices;

namespace UsingCppLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            CppFunction();
        }

        [DllImport("E:/Step/.NET/C#/DLL1.dll")]
        static extern void CppFunction();
    }
}