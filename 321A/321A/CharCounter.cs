using System;
using static System.Net.Mime.MediaTypeNames;

namespace _321A;

public class CharCounter
{
    public int[] Counts;
    public string Text;

    public void AddText(string inputText)
    {
        var range = 250;
        Counts = new int[range];
        inputText = "something";
        for (var index = 0; index < inputText.Length; index++)
        {
            Counts = new int[index];
        }
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