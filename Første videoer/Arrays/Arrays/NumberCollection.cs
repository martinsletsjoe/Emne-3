
namespace ArraysCS
{
    internal class NumberCollection
    {
        static int[] numbers = new int[5];

        public static void Run()
        {
            var count = 0;
            while (count < numbers.Length)
            {
                var number = MyConsole.AskForInt("Skriv inn et tall: ");
                var index = count;
                numbers[index] = number;
                count++;
                Show();
            }
        }

        static void Show()
        {
            foreach (var number in numbers)
            {
                //const int number = 5;
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }
}
