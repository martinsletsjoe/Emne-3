
namespace ArraysCS
{
    internal class NumberCollection
    {
        static int[] numbers = new int[5];

        public static void Run()
        {
            var count = 0;
            while (true)
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
            for (int i = 0; i < numbers.Length; i++)
            {
                //const int number = 5;
                var number = numbers[i];
                Console.WriteLine($"Element med indeks {i} har verdi {number}");
            }
        }

    }
}
