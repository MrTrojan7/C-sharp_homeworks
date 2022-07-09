using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_KeyListener
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter - Select\n" +
                "F1 - Grenade\n" +
                "Space - Jump\n" +
                (char)24 + " - Go Up\n" +
                (char)25 + " - Go Down\n" +
                (char)26 + " - Go Right\n" +
                "<- - Go Left\n" +
                "Esc - exit\n");
            // (char)27 - bad output

            KeyListener listener = new KeyListener();
            listener.Listen();


        }
    }
}