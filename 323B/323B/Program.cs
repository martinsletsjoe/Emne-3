﻿namespace _323B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \n" +
                          " - H, U, B\n" +
                          " - halvgardering: HU, HB, UB\n" +
                          " - helgardering: HUB\n" +
                          "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
            var betsText = Console.ReadLine();
            var matches = new TwelveMatches(betsText);


            while (true)
            {
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") break;
                var matchNo = Convert.ToInt32(command);
                Console.Write("Kommandoer: \n" +
                              " - H = scoring hjemmelag\n" +
                              " - B = scoring bortelag\n" +
                              " - X = kampen er ferdig\n" +
                              "Angi kommando: ");
                var team = Console.ReadLine();

                // stoppet her
                var selectedIndex = matchNo - 1;
                var selectedMatch = matches[selectedIndex];
                selectedMatch.AddGoal(team == "H");
                var correctCount = 0;
                for (var index = 0; index < matches.Length; index++)
                {
                    matches = matches[index];
                    var mathNo = index + 1;
                    var isBetCorrect = matches.IsBetCorrect();
                    var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                    if (isBetCorrect) correctCount++;
                    Console.WriteLine($"Kamp {matchNo}: {matches.GetScore()} - {isBetCorrectText}");
                }

                Console.WriteLine($"Du har {correctCount} rette.");
            }
        }
    }
}