namespace _323A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var match = new Match();
            var homegoals = match.HomeGoals;
            var awayGoals = match.AwayGoals;

            Console.Write("Gyldig tips: \n" +
                          " - H, U, B\n" +
                          " - halvgardering: HU, HB, UB\n" +
                          " - helgardering: HUB\n" +
                          "Hva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();



            while (match.MatchIsRunning)
            {
                Console.Write("Kommandoer: \n" +
                              " - H = scoring hjemmelag\n" +
                              " - B = scoring bortelag\n" +
                              " - X = kampen er ferdig\n" +
                              "Angi kommando: ");
                homegoals = match.UserCommand();
                Console.WriteLine($"Stillingen er {homegoals}-{awayGoals}.");
            }

            var result = match.HomeGoals == awayGoals ? "U" : homegoals > awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }

    }
}