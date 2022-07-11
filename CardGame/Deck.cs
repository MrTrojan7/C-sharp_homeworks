using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        private List<Card> cards;
        public Deck()
        {
            cards = new List<Card>(54);
            for (int i = 3; i < 7; i++)
            {
                int tempPower = 1;  // переменная для обозначения силы карты
                for (int j = 2; j <= 14; j++)
                {
                    if (j >= 2 && j <= 10) // если карты от 2 до 10, то они будут со значением 2, 3 и так до 10
                    {
                        cards.Add(new Card(j.ToString(), (char)i, tempPower));
                    }
                    else
                    {
                        switch (j)  //Валет, дама, король и туз
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
            Shuffle();
        }
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
        public void ShowDeck()
        {
            foreach (var item in cards)
                item.ShowCard();
            Console.WriteLine();
        }
        public Card GetCard()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return cards[cards.Count - 1];
        }
    }
}
