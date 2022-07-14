using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// Class of card
    /// </summary>
    class Card
    {
        private string value;
        private char type;
        private int power;

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="value">Value of card</param>
        /// <param name="type">Suit of card</param>
        /// <param name="power">Power of card</param>
        public Card(string value, char type, int power)
        {
            this.value = value;
            this.type = type;
            this.power = power;
        }
        /// <summary>
        /// Show card (value and suit)
        /// </summary>
        public void ShowCard()
        {
            Console.Write("|" + this.value + this.type + "| ");
        }
        
        /// <summary>
        /// Power of card
        /// </summary>
        public int Power
        {
            get { return this.power; }
        }
    }
}
