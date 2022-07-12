using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        public static void Main()
        {
            //Game game = new Game();
            //game.PlayGame();
            Deck a = new Deck();
            a.ShowDeck();
            Deck b = new Deck();
            a.ShowDeck();
            b.ShowDeck();
        }
    }
}