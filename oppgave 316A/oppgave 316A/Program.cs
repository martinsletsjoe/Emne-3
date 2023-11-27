namespace oppgave_316A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filename = "ordliste.txt";
            var data = File.ReadAllLines(filename);
            var uniqueWords = "";
            for (var index = 0; index < data.Length; index++)
            {
                var line = data[index];
                // Denne deler opp på tab mellomrom tror jeg?
                string[] words = line.Split('\t');

                // Henter ut ordet jeg ønsker fra hver linje

                if (uniqueWords  == words[1]) continue;
                uniqueWords  = words[1];
                Console.WriteLine(uniqueWords );
            }
        }
    }
}