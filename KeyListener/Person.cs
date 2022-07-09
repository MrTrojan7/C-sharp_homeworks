using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_KeyListener
{
    public class Person
    {
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
        public void Select()
        {
            Console.WriteLine("Select");
        }
        public void F()
        {
            Console.WriteLine("Grenade!");
        }
        public void Move_Left()
        {
            Console.WriteLine("Move Left");
        }
        public void Move_Right()
        {
            Console.WriteLine("Move Right");
        }
        public void Move_Up()
        {
            Console.WriteLine("Move Up");
        }
        public void Move_Down()
        {
            Console.WriteLine("Move Down");
        }
        public void Default()
        {
            Console.WriteLine("No action selected");
        }

        public void Escape()
        {
            Environment.Exit(0);
        }
    }
}
