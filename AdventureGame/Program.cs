using System;
using System.IO;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        {
            Console.WriteLine("Welcome to my game.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();
        }
        public static void first()
        {
            string choice;
            Console.WriteLine("Welcome to my game.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Punch Him");
            Console.WriteLine("2. Cry");
            Console.WriteLine("3. Pee a little.");
            Console.Write("Choice : ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choice)
            {
                case "1":
                case "punch him":
                case "punch":
                    {
                        Console.WriteLine("Your fist pounds into Mr. Yolchu's face.");
                        Console.WriteLine("All the other students in class cheer your name.");
                        Console.WriteLine("Mrs. Yolchu hears the commotion and comes to investigate.");
                        Console.WriteLine("When she sees her husband crying in the corner, she shoots you with her lazer eyes.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "cry":
                    {
                        Console.WriteLine("Mr. Yolchu's face becomes the color of ripe tomatoes");
                        Console.WriteLine("You wanna cry? Do it out in the hall! He screams at the top of his lungs .");
                        Console.WriteLine("Press 'Enter' to continue .");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "pee":
                case "pee a little":
                    {
                        Console.WriteLine("Mr. Yolchu sniffs the air. The other students begin plugging their noses.");
                        Console.WriteLine("Did you just ...? Get out of here!  He screams at the top of his lungs .");
                        Console.WriteLine("Press 'Enter' to continue .");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command .....");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.WriteLine("Welcome to my game.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }

        }
        public static void second() 
        {
            Random rnd = new Random();
            string[] secOptions = {"In the hallway, you see that cops are searching lockers.",
            "In the hallway, you see your stalker walking toward you.",
            "In the hallway,the fire alarm goes off"
            };
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];
            string secChoice;
            Console.WriteLine(secText);
            Console.WriteLine("Do you try to hide in the bathroom; Yes or No?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();
            if (secChoice == "yes" || secChoice == "y")
            {
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("A meteor slams into the school at that at that exact moment, killing you instantly.");
                Console.WriteLine("Press 'Enter' to continue. ");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("I don't understand that command .....");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.WriteLine("Welcome to my game.");
                Console.ReadLine();
                first();
           
            }

        }
        public static void third()
        {
            int age;
            Console.WriteLine("You burst into the bathroom and all of your friends and family.");
            Console.WriteLine("The yell 'Suprise!' and you remember it's your birthday. ");
            Console.WriteLine("How old are you today?.");
            Console.Write("Age : ");
            int.TryParse(Console.ReadLine(), out age);
            while (age < 100)
            {
                Console.WriteLine("Seriously You look older that that!");
                Console.WriteLine("How old are you really?");
                Console.Write("Age : ");
                int.TryParse(Console.ReadLine(), out age);
                break;

            }
            Console.WriteLine("How, you're old! You must have been held back a lot !");
            youWin();


        }
        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("At your funeral, the sing songs of your bravery.Then they remember who's funeral they are attending and they take it all back ");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
        public static void youWin() 
        {
            Console.Clear();
            Console.WriteLine("Your birthday party was a big hit.");
            Console.WriteLine("Great job! You won!");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

    }
}
