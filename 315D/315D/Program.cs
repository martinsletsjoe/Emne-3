namespace _315D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv noe tekst");
            var userAnswer = Console.ReadLine();
            string[] listedWords = userAnswer.Split(' ');
            var longestWord = "";

            Console.WriteLine($"Det er {listedWords.Length} ord i teksten din");
            foreach (var word in listedWords)
            {

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"{longestWord} er det lengste ordet i teksten");
        }
    }
}
//split('')