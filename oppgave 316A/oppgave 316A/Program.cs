namespace oppgave_316A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = GetWords();

            GetWordEnding(words);

        }

        private static void GetWordEnding(string[] words)
        {
            Random random = new Random();
            var randomWordIndex = random.Next(words.Length);
            var word = words[randomWordIndex];

            var randomWordEnd = new List<string>();
            string c;
            for (int i = word.Length - 3; i < word.Length; i++)
            {
                c = word[i].ToString();
                randomWordEnd.Add(c);
            }

            string resultString = string.Join("", randomWordEnd);

            Console.WriteLine(resultString);
            Console.WriteLine(word);
        }


        private static string[] GetWords()
        {
            var filename = "ordliste.txt";
            var data = File.ReadAllLines(filename);

            var lastWord = string.Empty;
            var uniqueWords = new List<string>();
            foreach (var line in data)
            {
                // Denne deler opp på tab mellomrom tror jeg?
                string[] parts = line.Split('\t');

                // Henter ut ordet jeg ønsker fra hver linje
                var word = parts[1];

                if (word != lastWord
                    && word.Length > 6
                    && word.Length <= 10
                    && !word.Contains("-"))
                {
                    uniqueWords.Add(word);
                }

                lastWord = word;
            }

            return uniqueWords.ToArray();
        }
    }
}