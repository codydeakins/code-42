using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBike
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.Title = "-========== LIGHT BIKE ==========-";
            Console.ForegroundColor = ConsoleColor.Green;
            Title.WriteTitle();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Welcome to Light Bike!");
            Console.ReadKey();
            Console.Clear();
            bool exit = true;
            Program X = new Program();
            X.Speed = 75;
            X.RandomBar = 97;
            X.BikeChar = '@';
            X.timesDied = 0;

            while (exit)
            {
                Console.Clear();
                Console.WriteLine("1) How to Play\n2) Play\n3) Difficulty\n4) Change Bike Character\n5) Exit\n\n");
                if (X.timesDied != 0)
                {
                    Console.SetCursorPosition(0, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("You have died {0} time{1}...", X.timesDied, X.timesDied == 1 ? "":"s");
                    Console.SetCursorPosition(0, 7);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                string userInput = Console.ReadLine().ToUpper();
                switch (userInput)
                {
                    case "1":
                    case "H":
                    case "HOW":
                    case "HOW TO":
                    case "HOW TO PLAY":
                        Console.Clear();
                        Console.WriteLine("You will play as the Blue Bike in the bottom of the screen.  \nPress a key to start the game." + 
                            " \nYou can change directions by using the arrow keys.\nBe the last to survive to win!\n" +
                            "After the game ends, press ENTER to return to menu.\n");
                        Console.ReadKey();
                        break;
                    case "2":
                    case "P":
                    case "PLAY":
                        Console.Clear();
                        X.RunGame();
                        break;
                    case "3":
                    case "D":
                    case "DIF":
                    case "DIFFICULTY":
                        bool difBool = true;
                        while (difBool)
                        {
                            Console.Clear();
                            Console.WriteLine("1) Easy\n2) Normal\n3) Hard\n4) Expert\n\n");
                            
                            string userDifficulty = Console.ReadLine().ToUpper();
                            switch (userDifficulty)
                            {
                                case "1":
                                case "E":
                                case "EASY":
                                    X.Speed = 100;
                                    X.RandomBar = 95;
                                    difBool = false;
                                    break;
                                case "2":
                                case "N":
                                case "NORMAL":
                                    X.Speed = 75;
                                    X.RandomBar = 97;
                                    difBool = false;
                                    break;
                                case "3":
                                case "H":
                                case "HARD":
                                    X.Speed = 50;
                                    X.RandomBar = 98;
                                    difBool = false;
                                    break;
                                case "4":
                                case "X":
                                case "EXPERT":
                                    X.Speed = 25;
                                    X.RandomBar = 99;
                                    difBool = false;
                                    break;
                                default:
                                    Console.WriteLine("Did not understand Input. . .");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case "4":
                    case "C":
                    case "CHANGE":
                    case "CHANGE BIKE CHARACTER":
                    case "CHANGE BIKE":
                        Console.Clear();
                        bool loop = false;
                        char letter = 'a';
                        while (!loop)
                        {
                            Console.Write("Please enter one char and hit enter: ");
                            loop = Char.TryParse(Console.ReadLine(), out letter);
                        }
                        X.BikeChar = letter;
                        break;
                    case "5":
                    case "E":
                    case "X":
                    case "EXIT":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Did not understand Input. . .");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Thanks For Playing!\n");


            
        }
    }
}
