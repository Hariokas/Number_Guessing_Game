using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNumber = r.Next(0, 100);
            bool hasGuessedCorrectly = false;

            while (hasGuessedCorrectly == false)
            {
                try
                {
                    Console.Write("Guess the number between 0 and 100!: ");
                    var guessNumber = Int32.Parse(Console.ReadLine());

                    if (guessNumber > winNumber)
                        Console.WriteLine($"Try lower number!\n");

                    if (guessNumber < winNumber)
                        Console.WriteLine($"Try higher number!\n");

                    if (guessNumber == winNumber)
                    {
                        hasGuessedCorrectly = true;
                        Console.WriteLine($"You've guessed correctly! The secret number was {winNumber}\n");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Unexpected input!");
                }
            }
            Console.WriteLine("Thank you for playing!\nPress any key to exit the game.");
            Console.ReadKey(true);
        }
    }
}
