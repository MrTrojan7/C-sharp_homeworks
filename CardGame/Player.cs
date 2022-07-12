using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// Class that describes the player
    /// </summary>
    class Player
    {
        private List<Card> playerCard;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Player()
        {
            playerCard = new List<Card>();
        }

        /// <summary>
        /// Show all cards of player
        /// </summary>
        public void ShowCards()
        {
            foreach (var item in playerCard)
                item.ShowCard();
            Console.WriteLine();
        }

        /// <summary>
        /// add new card in deck of player
        /// </summary>
        /// <param name="card">object Card</param>
        public void AddCard(Card card)
        {
            playerCard.Add(card);
        }
        /// <summary>
        /// Delete first card from deck
        /// </summary>
        public void RemoveFirst()
        {
            this.playerCard.RemoveAt(0);
        }
        /// <summary>
        /// Get power card of index
        /// </summary>
        /// <param name="index">index card of deck</param>
        /// <returns></returns>
        public int GetPower(int index)
        {
            return playerCard[index].Power;
        }
        /// <summary>
        /// get first card of player deck
        /// </summary>
        /// <returns>return first card</returns>
        public Card GetFirstCard()
        {
            return playerCard[0];
        }
        /// <summary>
        /// get size of deck
        /// </summary>
        /// <returns>return int size</returns>
        public int GetCountOfCards()
        {
            return playerCard.Count;
        }
    }
}