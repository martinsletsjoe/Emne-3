using System;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace _321A;

public class CharCounter
{
    public int[] Counts;

    public CharCounter()
    {
        var range = 250;
        Counts = new int[range];
    }

    public void AddText(string inputText)
    {
        foreach (var character in inputText)
        {
            Counts[(int)character]++;
        }
    }
    public void ShowCounts()
    {
        var range = 250;
        for (int i = 0; i < range; i++)
        {
            if (Counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + Counts[i]);
            }
        }
    }
}