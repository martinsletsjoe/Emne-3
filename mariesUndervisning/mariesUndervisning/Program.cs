using System.ComponentModel;
using System.ComponentModel.Design;

namespace mariesUndervisning
{
    internal class Program
    {
        private static string? displayNumber;
        static void Main(string[] args)
        {
            ArrayTest();
        }

        static void ArrayTest()
        {
            var numbers = new int[10];
            var fruits = new string[]{"Banana", "Strawberry", "cherry"};

            numbers[0] = 1;

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }



        static void Menu()
        {
            var isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a number between 0 -> 9, press x to finish");

                displayNumber = Console.ReadLine();
                if (displayNumber == "x") {break; }
                int displayInt = int.Parse(displayNumber!);

                //Random random = new();
                //displayNumber = random.Next(0, 10);

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Add: + ");
                Console.WriteLine("Subtract: - ");
                Console.WriteLine("Multiply: * ");
                Console.WriteLine("Divide: / ");

                var userInput = Console.ReadLine();

                Console.WriteLine($"What number do you want to {userInput}");

                var userNumber = int.Parse(Console.ReadLine() ?? string.Empty);

                if (userInput == "+")
                {
                    displayInt = Add(displayInt, userNumber);
                }
                else if (userInput == "-")
                {
                    displayInt = Subtract(displayInt, userNumber);
                }
                else if (userInput == "*")
                {
                    displayInt = Multiply(displayInt, userNumber);
                }
                else if (userInput == "/")
                {
                    displayInt = Divide(displayInt, userNumber);
                }
                Console.WriteLine($"Result: {displayInt}");

            }
        }

        static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
        static int Subtract(int firstNumber, int secondNumber)
        {
            int sum = firstNumber - secondNumber;
            return sum;
        }
        static int Multiply(int firstNumber, int secondNumber)
        {
            int sum = firstNumber * secondNumber;
            return sum;
        }
        static int Divide(int firstNumber, int secondNumber)
        {
            int sum = firstNumber / secondNumber;
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
