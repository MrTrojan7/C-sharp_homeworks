using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private string value;
        private char type;
        private int power;

        public Card(string value, char type, int power)
        {
            this.value = value;
            this.type = type;
            this.power = power;
        }
        
        public void ShowCard()
        {
            Console.Write("< " + this.value + this.type + " >");
        }
        
        public int Power
        {
            get { return this.power; }
        }
    }
}
