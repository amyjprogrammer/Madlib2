using System;

namespace Madlib2
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding a new method and breaking up the code
            GreetingUser();

            int selectedNum = 0; //starts the while loop
            ColorMessage(ConsoleColor.Yellow, "Please choose 1, 2 or 3: ");

            while (selectedNum != 1 && selectedNum != 2 && selectedNum != 3)
            {
                //get players input
                string input = Console.ReadLine();

                if (!int.TryParse(input, out selectedNum))
                {
                    //checking to make sure the user put a number
                    //also using the ColorMessage method
                    ColorMessage(ConsoleColor.Red, "Please enter a number: ");

                    //Keep going;
                    continue;
                }

                //taking the players string answer and converting to int
                selectedNum = Int32.Parse(input);

                //Looking for 1, 2 or 3
                if ((selectedNum != 1) && (selectedNum != 2) && (selectedNum != 3))
                {
                    //using Color function again
                    ColorMessage(ConsoleColor.DarkBlue, "Enter either 1, 2 or 3: ");
                }

                //Finally got 1, 2 or 3 (show the prediction)
                switch (selectedNum)
                {
                    case 1:
                        Console.WriteLine("I knew you loved cats!");
                        break;
                    case 2:
                        Console.WriteLine("I knew you loved dogs!");
                        break;
                    case 3:
                        Console.WriteLine("I knew you loved both cats and dogs!");
                        break;
                }
            }

            LuckyNum();
            SecretCrush();
            
        }

        static void GreetingUser()
        {
            Console.WriteLine("Welcome to Madame Sonia's MadLib and Guessing Game");
            ColorMessage(ConsoleColor.DarkCyan, "Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("I would have guessed {0} for you.", playerName);
            MadLib(playerName);
        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        static void LuckyNum()
        {
            Random random = new Random();
            int luckyGuess = random.Next(101);
            Console.WriteLine("Your lucky number today is {0}.", luckyGuess);
  
        }

        static void SecretCrush()
        {
            ColorMessage(ConsoleColor.DarkMagenta, "What is the first name for your secret male crush: ");
            string crush = Console.ReadLine();
            if (crush.ToUpper() == "CHRIS")
            {
                Console.WriteLine("I know right.  Chris Hemsworth, Chris Pratt, Chris Evans, Chris Pine...etc.");
            } else
            {
                Console.WriteLine("I really thought you would say Chris.  I guess I am having an off day.");
            }
        }

        static void MadLib(string playerName)
        {
            Console.WriteLine("This MadLib is for {0}", playerName);
        }
    }
}
