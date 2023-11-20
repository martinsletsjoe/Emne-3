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
            char[] vocals = { 'a', 'e', 'o', 'u', 'i', 'æ', 'ø', 'å', };

            Console.WriteLine($"Det er {listedWords.Length} ord i teksten din");
            for (var index = 0; index < listedWords.Length; index++)
            {
                var word = listedWords[index];
                var numberOfVocals = 0;

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
                numberOfVocals = vowels(vocals, numberOfVocals, listedWords, index);
                Console.WriteLine($"{listedWords[index]} has {numberOfVocals} vowels in it");
            }

            Console.WriteLine($"{longestWord} er det lengste ordet i teksten");
        }

        private static int vowels(char[] vocals, int numberOfVocals, string[] listedWords, int index)
        {
            foreach (var character in listedWords[index])
            {
                foreach (var vocal in vocals)
                {
                    if (character == vocal)
                    {
                        numberOfVocals++;
                    }
                }
            }
            return numberOfVocals;
        }
    }
}
//split('')