namespace _323A;

internal class Match
{
    public int HomeGoals { get; set; }
    public int AwayGoals { get; set; }
    public bool MatchIsRunning { get; set; }

    public Match()
    {
        HomeGoals = 0;
        AwayGoals = 0;
        MatchIsRunning = true;
    }

    public int UserCommand()
    {
        var command = Console.ReadLine();

        MatchIsRunning = command != "X";
        if (command == "H") HomeGoals++;
        else if (command == "B") AwayGoals++;
        return HomeGoals;
    }

}