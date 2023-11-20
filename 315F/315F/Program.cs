namespace _315F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = { ' ', '1', '3', '4', '2', '5', '7', '8', '6' };

            while (true)
            {
                printNumbers(numbers);
                Console.ReadLine();

                MoveEmptySpace(numbers);

            }
        }

        private static void printNumbers(char[] numbers)
        {
            for (var index = 0; index < numbers.Length; index++)
            {
                if (index % 3 == 0 && index != 0)
                {
                    Console.WriteLine("\n");
                }

                Console.Write(numbers[index]);
            }

            Console.WriteLine();

        }

        static void MoveEmptySpace(char[] numbers)
        {
            // Find the empty space
            int emptyIndex = Array.IndexOf(numbers, ' ');

            // Check that the empty space is not at the end
            if (emptyIndex < numbers.Length - 1)
            {
                (numbers[emptyIndex], numbers[emptyIndex+1]) = (numbers[emptyIndex+1], numbers[emptyIndex]);
            }
        }
    }
}