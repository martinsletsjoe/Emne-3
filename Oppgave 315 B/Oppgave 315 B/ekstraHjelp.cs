using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_315_B
{
    internal class ekstraHjelp
    {
        public static void run()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine() ?? string.Empty;
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                    //}
                    //for (var i = 0; i < range; i++)
                    //{
                    //    if (counts[i] > 0)
                    //    {

                    Console.WriteLine(character + " - " + counts[character]);
                    //    }
                }
            }
        }

        public static void run2()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower();
                for (var i = 0; i < text.Length; i++)
                    //foreach (var character in text ?? string.Empty)
                {
                    counts[text[i]]++;
                    //counts[character]++;
                    //Console.WriteLine(counts[text[i]]);

                    if (counts[text[i]] > 0)
                    {
                        var character = text[i];
                        Console.WriteLine(character + " - " + counts[text[i]]);
                    }
                }
            }
        }

        public static void run3()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine() ?? string.Empty;
                numberOfletters(text, counts);
                letter(range, counts);
            }
        }

        private static void numberOfletters(string? text, int[] counts)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
        }

        private static void letter(int range, int[] counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
        }
    }
}
