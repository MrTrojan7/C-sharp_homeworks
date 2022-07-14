using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// Deck class
    /// </summary>
    class Deck
    {
        /// <summary>
        /// Field of class
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Default constructor
        /// Create a deck of 52 cards
        /// </summary>
        public Deck()
        {
            cards = new List<Card>(52);
            for (int i = 3; i < 7; i++) // suit of card
            {
                int tempPower = 1;  // power of card
                for (int j = 2; j <= 14; j++) // card |2| - |T|
                {
                    if (j >= 2 && j <= 10) // card |2| - |10|
                    {
                        cards.Add(new Card(j.ToString(), (char)i, tempPower));
                    }
                    else
                    {
                        switch (j)  // card |V|, |Q|, |K|, |T|
                        {
                            case 11:
                                cards.Add(new Card("V", (char)i, tempPower));
                                break;
                            case 12:
                                cards.Add(new Card("Q", (char)i, tempPower));
                                break;
                            case 13:
                                cards.Add(new Card("K", (char)i, tempPower));
                                break;
                            case 14:
                                cards.Add(new Card("A", (char)i, tempPower));
                                break;
                        }
                    }
                    ++tempPower;
                }
            }
            Shuffle(); // at the end of the constructor, the deck is shuffled
        }
        /// <summary>
        /// Shuffle the deck
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = cards.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
        }
        /// <summary>
        /// Show the deck
        /// </summary>
        public void ShowDeck()
        {
            foreach (var item in cards)
                item.ShowCard();
            Console.WriteLine();
        }
        /// <summary>
        /// Method that returns the last card of the deck
        /// </summary>
        /// <returns>last card</returns>
        public Card GetCard()
        {
            return cards[cards.Count - 1];
        }
        /// <summary>
        /// Method that remove the last card of the deck
        /// </summary>
        public void RemoveCard()
        {
            cards.RemoveAt(cards.Count - 1);
        }
    }
}
