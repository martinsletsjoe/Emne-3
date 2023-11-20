using System.Diagnostics.Metrics;

namespace _315E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listeAvTall = NumberArray(1000, 1028, 7);
            Console.WriteLine(string.Join(", ", listeAvTall));
        }


        static int[] NumberArray(int startValue, int EndValue, int jumpDifference)
        {
            List<int> IHATEWORDING = new List<int>();
            for (int i = startValue; i <= EndValue; i += jumpDifference)
            {
                IHATEWORDING.Add(i);
            }

            int[] countThingy = IHATEWORDING.ToArray();
            return countThingy;
        }
    }
}