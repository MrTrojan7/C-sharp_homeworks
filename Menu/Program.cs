using System;

namespace HomeTask
{
    class Program
    {

        delegate void Operation();
        public static void Exit()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
        public static void NewGame()
        {
            Console.WriteLine("New Game!");
        }
        public static void LoadGame() 
        {
            Console.WriteLine("Loading...");
        }
        public static void Rulse()
        {
            Console.WriteLine("This game is not have rules!");
        }
        public static void AboutAuthor()
        {
            Console.WriteLine
            ("Version 0.0. This game was created " +
            "Crazy Senior Software Developer from Ukraine. " +
            "Contact number: +0. All rights reserved.");
        }

        static void Main()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Read Rulse");
            Console.WriteLine("4 - About");
            Console.WriteLine("0 - Exit");
            Operation operation;
            while (true)
            {
                int click = Convert.ToInt32(Console.ReadLine());
                switch (click)
                {
                    case 1:
                        operation = NewGame;
                        operation();
                        break;
                    case 2:
                        operation = LoadGame;
                        operation();
                        break;
                    case 3:
                        operation = Rulse;
                        operation();
                        break;
                    case 4:
                        operation = AboutAuthor;
                        operation();
                        break;
                    default:
                        operation = Exit;
                        operation();
                        break;
                }
            }
        }
    }
}