using static System.Net.Mime.MediaTypeNames;

namespace _321A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = new CharCounter();
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                counter.AddText(text);
                counter.ShowCounts();
            }
        }
    }
}
