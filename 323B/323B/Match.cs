namespace _323B;

public class Match
{
    public int HomeGoals { get; private set; }
    public int AwayGoals { get; private set; }
    public string Bet { get; private set; }

    public Match(string bet)
    {
        Bet = bet;
    }

    public void AddGoal(bool isHomeTeam)
    {
        if (isHomeTeam) HomeGoals++;
        else AwayGoals++;
    }


    public bool IsBetCorrect()
    {
        var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        return Bet.Contains(result);
    }

    public string GetScore()
    {
        return HomeGoals + " - " + AwayGoals;
    }
}