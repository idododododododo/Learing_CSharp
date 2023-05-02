using System;

namespace GussingNumGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            Random random = new Random();
            int TheNumber = random.Next(min, max + 1);
            bool GameOver = false;
            int Guess;
            
            
            while (!GameOver)
            {
                Console.WriteLine("Enter a number between " + min + " and " + max + ":");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out Guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }
                
                if (Guess == TheNumber)
                {
                    Console.WriteLine("Good job! The number is " + TheNumber + ".");
                    GameOver = true;
                }
                else if (Guess > TheNumber)
                {
                    Console.WriteLine("The number is too big.");
                }
                else if (Guess < TheNumber)
                {
                    Console.WriteLine("The number is too small.");
                }
            }
        }
    }
}