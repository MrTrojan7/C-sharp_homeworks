using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_KeyListener
{
    public class KeyListener
    {
        public delegate void KeyDelegate();
        public event KeyDelegate KeyPress;
        public void Listen()
        {
            Person person = new Person();
            ConsoleKey key;
            while (true)
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        Console.WriteLine("Enter");
                        KeyPress = person.Select;
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Escape");
                        KeyPress = person.Escape;
                        break;
                    case ConsoleKey.F1:
                        Console.WriteLine("F1");
                        KeyPress = person.F;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("Space");
                        KeyPress = person.Jump;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        KeyPress = person.Move_Left;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        KeyPress = person.Move_Right;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        KeyPress = person.Move_Down;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        KeyPress = person.Move_Up;
                        break;
                    default:
                        Console.WriteLine("\rdefault");
                        KeyPress = person.Default;
                        break;
                }
                KeyPress.Invoke();
            }
        }
    }
}
