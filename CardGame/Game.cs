using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// Класс описывающий простую игру в карты
    /// </summary>
    class Game
    {
        /// <summary>
        /// Поля класса
        /// </summary>
        public delegate void KeyDelegate();
        public event KeyDelegate KeyPress; 
        private List<Card> cards;    
        private Deck deck_of_game;
        private List<Player> players; 
        //private int count_of_players;
        private static Random random = new Random();

        /// <summary>
        /// Конструктор по умолчанию создает колоду из 54 кард и 2 игрока
        /// </summary>
        public Game() : this(2) { }

        /// <summary>
        /// Параметризированный конструктор (в качестве параметра передаётся колличество игроков)
        /// </summary>
        public Game(int count_of_players)
        {
            deck_of_game = new Deck();
            players = new List<Player>(count_of_players); 
            for (int i = 0; i < count_of_players; i++)
            {
                players.Add(new Player());
            }
            GiveCards();
        }

        /// <summary>
        /// Специальный метод для раздачи карт игрокам
        /// </summary>
        private void GiveCards()
        {
            for (int i = 0; i < players.Count(); i++)
            {
                for (int j = 0; j < 54 / players.Count(); j++)
                {
                    players[i].AddCard(deck_of_game.GetCard());
                    deck_of_game.RemoveCard();
                }
            }
        }

        /// <summary>
        /// показ карт игроков
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
        /// Метод для розыграша карт.
        /// Игроки сравнивают первые карты
        /// У кого значение карты больше - тот и забирает карты и кладет их в конец колоды
        /// </summary>
        private void Round()
        {
            List<Card> temp_deck_of_round = new List<Card>();  //создание временного хранилища сравниваемых карт
            int temp_index = 0;
            int temp_power = 0;
            for (int i = 0; i < players.Count; i++)
            {
                temp_deck_of_round.Add(players[i].GetFirstCard());
                Console.Write("Player # " + (i + 1) + " put the card: ");
                temp_deck_of_round[i].ShowCard();
                if (players[i].GetFirstCard().Power > temp_power)
                {
                    temp_index = i;
                    temp_power = players[i].GetFirstCard().Power;
                }
                players[i].RemoveFirst();
            }
            Console.WriteLine("Player # " + temp_index + " is winner in this round");
            for (int i = 0; i < players.Count; i++)
            {
                players[temp_index].AddCard(temp_deck_of_round[i]);
            }
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].GetCountOfCards() == 0)
                {
                    players.RemoveAt(i);
                    Console.WriteLine("Player # " + i + " is empty!");
                    i = 0;
                }
            }
            
        }

        /// <summary>
        /// Метод, который начинает игру
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("You just started a new card game");
            Console.WriteLine("Count of players: " + players.Count);
            Console.WriteLine("What do you want?");
            while (true)
            {
                Console.WriteLine("1 - Show Players cards");
                Console.WriteLine("2 - Make a round");
                Console.WriteLine("ESC - EXIT the Game");
                ConsoleKeyInfo key = Console.ReadKey(true); // переменная для реагирования на нажатие
                if (key.Key == ConsoleKey.D1)
                {
                    ShowPlayersCard();
                }
                if (key.Key == ConsoleKey.D2)
                {
                    Round();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nHave a good day!\n");
                    break;
                }
                if (players.Count == 1)
                {
                    Console.WriteLine("\nPlayer # " + players.Count + " is winner!\n");
                    break;
                }
                KeyPress?.Invoke();
            }
        }
    }
}