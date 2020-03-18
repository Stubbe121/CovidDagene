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

            while (!run)
            {
                try
                {
                    Console.WriteLine("Guess the number: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("Congrats you guessed it!!!");
                    }
                    else if (guess != number)
                    {
                        Console.WriteLine("Wrong number try again");
                    }
                }
            }
        }
    }
}
