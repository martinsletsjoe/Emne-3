using System.ComponentModel;
using System.ComponentModel.Design;

namespace mariesUndervisning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }
        private static int _displayNumber = 2;


        static void Menu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Add: + ");
            Console.WriteLine("Subtract: - ");
            Console.WriteLine("Multiply: * ");
            Console.WriteLine("Divide: / ");

            var userInput = Console.ReadLine();

            Console.WriteLine($"What number do you want to {userInput}");

            var userNumber = Console.Read();

            if (userInput == "+")
            {
                Add(_displayNumber, userNumber);
            }
            else if (userInput == "-")
            {

            }
            else if (userInput == "*")
            {
                
            }else if (userInput == "/")
            {

            }
            else
            {
                Console.WriteLine("wrong input, please try again.");
            }
        }

        static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
    }
}

// Kalkulator
// Tall
// userinput
// pluss/minus
// resultat
// reset
