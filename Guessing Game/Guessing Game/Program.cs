using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            bool run = false;
            Random n = new Random();
            int number = n.Next(1,10);
            int guessCount = 0;
            int guessLimit = 3;
            bool OutOfGuesses = false;

            while (!run && !OutOfGuesses)
            {
                try
                {
                    Console.WriteLine("Guess the number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guessCount < guessLimit)
                    {
                        if (guess == number)
                        {
                            Console.WriteLine("Congrats you guessed it!!!");
                            run = true;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Number chosen is too high");
                            guessCount++;
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine("Number chosen is too low");
                            guessCount++;
                        }
                    }
                    else
                    {
                        OutOfGuesses = true;
                    }
                }
                catch(FormatException fEx)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
