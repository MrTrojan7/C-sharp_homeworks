using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// Class of simple card game
    /// </summary>
    class Game
    {
        /// <summary>
        /// Fields of class
        /// </summary>
        public delegate void KeyDelegate();
        public event KeyDelegate KeyPress;    
        private Deck deck_of_game;
        private List<Player> players;

        /// <summary>
        /// Default constructor (create 2 players)
        /// </summary>
        public Game() : this(2) { }

        /// <summary>
        /// Constructor with params (count of players and 52 cards)
        /// <param name="count_of_players">Count of players (min = 2)</param>
        /// </summary>
        public Game(int count_of_players)
        {
            IsCorrectCountOfPlayers(count_of_players);
            deck_of_game = new Deck();
            players = new List<Player>(count_of_players); 
            for (int i = 0; i < count_of_players; i++)
            {
                players.Add(new Player());
            }
            GiveCards();
        }

        /// <summary>
        /// Distribution of cards to players. 
        /// If the number of players is not a multiple of the number of cards - deal one card to each player until the deck runs out
        /// </summary>
        private void GiveCards()
        {
            int j = 0;
            for (int i = 0; i < 52; i++)
            { 
                players[j].AddCard(deck_of_game.GetCard());
                deck_of_game.RemoveCard();
                ++j;
                if(j == players.Count)
                    j = 0;
            }
        }
        /// <summary>
        /// Show player's cards
        /// </summary>
        private void ShowPlayersCard()
        {
            for (int i = 0; i < players.Count(); i++)
            {
                Console.WriteLine("Player # " + (i + 1));
                players[i].ShowCards();
            }
        }
        /// <summary>
        /// Method responsible for 1 round
        /// </summary>
        private void Round()
        {
            /// <remarks> Creating a temporary storage of round cards </remarks>
            List<Card> temp_deck_of_round = new List<Card>();
            int temp_index = 0; // index of most power
            int temp_power = 0; // most power (for search and compare)
            /// <remarks>
            /// Show first player's cards 
            /// Transfer cards to the temporary store and determining the strongest card
            /// </remarks>
            for (int i = 0; i < players.Count; i++) 
            {
                temp_deck_of_round.Add(players[i].GetFirstCard());
                Console.Write("Player # " + (i + 1) + " put the card: ");
                temp_deck_of_round[i].ShowCard();
                Console.WriteLine();
                if (players[i].GetFirstCard().Power > temp_power)
                {
                    temp_index = i;
                    temp_power = players[i].GetFirstCard().Power;
                }
                players[i].RemoveFirst();
            }
            /// <remarks>// Show winner </remarks>
            Console.WriteLine("Player # " + (temp_index + 1) + " is winner in this round");
            for (int i = 0; i < players.Count; i++) // Add cards to winner
            {
                players[temp_index].AddCard(temp_deck_of_round[i]);
            }
            /// <remarks>
            /// this action is specially brought here,
            /// because if it transfer to the first cycle in this method
            /// player will be removed BEFORE the end of the round
            /// </remarks>
            int temp_index_of_remove = 0; // for correct print number of removed players (if in 1 round > 1 removed player)
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].GetCountOfCards() == 0)
                {
                    players.RemoveAt(i);
                    Console.WriteLine("Player # " + (i + 1 + temp_index_of_remove) + " is empty!");
                    i = 0; 
                    temp_index_of_remove += 1;
                }
            }
        }

        /// <summary>
        /// Start the game
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("You just started a new card game");
            Console.WriteLine("Count of players: " + players.Count);
            Console.WriteLine("What do you want?");
            ///<summary> Cycle of game </summary>
            while (true)
            {
                Console.WriteLine("1 - Show Players cards");
                Console.WriteLine("2 - Make a round");
                Console.WriteLine("ESC - EXIT the Game");
                ConsoleKeyInfo key = Console.ReadKey(true);
                /// <remarks> Show player's cards </remarks>
                if (key.Key == ConsoleKey.D1)
                {
                    ShowPlayersCard();
                }
                /// <remarks> Play 1 round </remarks>
                if (key.Key == ConsoleKey.D2)
                {
                    Round();
                }
                /// <remarks> End game </remarks>
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nHave a good day!\n");
                    break;
                }
                /// <remarks>
                /// Determination of the winner
                /// End game
                /// </remarks>
                if (players.Count == 1)
                {
                    Console.WriteLine("\nPlayer # " + (players.Count + 1) + " is winner!\n");
                    break;
                }
                /// <remarks> Incorrect pressing </remarks>
                KeyPress?.Invoke();
            }
        }
        private void IsCorrectCountOfPlayers(int count_of_players)
        {
            try
            {
                if (count_of_players < 2)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect count of players ( < 2)");
                Environment.Exit(0);
            }
        }
    }
}