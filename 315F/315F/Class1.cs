namespace _315F
{
    internal class NumberPuzzle
    {
        private static char[] _numbers;

        public static void Run()
        {
            _numbers = " 13425786".ToCharArray();


            while (true)
            {
                Show();
                Console.Write("Hvilket tall vil du flytte? ");
                var number = Console.ReadLine();
                Move(number[0]);
            }
        }

        private static void Move(char number)
        {
            var index = Array.IndexOf(_numbers, number);
            var rowIndex = index / 3;
            var colIndex = index % 3;
            var didSwap = SwapIsBlank(rowIndex - 1, colIndex)
                || SwapIsBlank(rowIndex + 1, colIndex)
                || SwapIsBlank(rowIndex, colIndex + 1)
                || SwapIsBlank(rowIndex, colIndex - 1);

        }

        private static bool SwapIsBlank(int rowIndex, int colIndex)
        {
            if(rowIndex < 0 || rowIndex > 2 || colIndex < 0 || colIndex > 2) { return false; }
            var index = rowIndex * 3 + colIndex;
            return _numbers[index] == ' ';
        }

        private static void Show()
        {
            Console.Clear();
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                var number = _numbers[i];
                Console.Write(number);
            }

            Console.WriteLine("\n");

            DateTime.Now.Second
        }
    }
}
/*
 *     char[] numbers = { ' ', '1', '3', '4', '2', '5', '7', '8', '6' };

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
*/