using System;

namespace Madlib2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Madame Sonia's MadLib and Guessing Game");
            Console.Write("Please tell me your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("I would have guessed {0} for you.", playerName);

            while (true)
            {
                int selectedNum = 0; //starting with a wrong number so it can start in the while loop
                Console.Write("Please choose either 1, 2 or 3: ");


                while (selectedNum != 1 || selectedNum != 2 || selectedNum != 3)
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

                    if (selectedNum != 1)
                    {
                        //using Color function again
                        ColorMessage(ConsoleColor.DarkBlue, "Enter either 1, 2 or 3: ");
                    }
                }

                int selectedNumber = Convert.ToInt32(Console.ReadLine());

                switch (selectedNumber)
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

        }

        

        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
