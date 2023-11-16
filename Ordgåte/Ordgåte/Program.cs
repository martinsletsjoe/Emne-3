using System;
using System.IO;

namespace Ordgåte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 10);
            var completedItMate = false;
            while (!completedItMate)
            {
                var tries = 1;
                //Console.WriteLine(number);
                Console.WriteLine("Gjett ett tall mellom 1 og 10");
                var guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);
                if (number != guess)
                {
                    tries++;
                    Console.WriteLine(guess > number ? "for høyt!" : "for lavt!");
                }
                else
                {
                    Console.WriteLine($"Riktig! Du hadde {tries} forsøk!");
                    completedItMate = true;
                }
            }
        }
    }
}
/*           
   
   
   
*/
