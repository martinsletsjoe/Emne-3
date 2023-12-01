namespace _323B;

public class TwelveMatches
{
    public int HomeGoals { get; private set; }
    public int AwayGoals { get; private set; }
    public static int MatchNo { get; private set; }
    public string Bet { get; }


    public TwelveMatches(string bet, int matchNo)
    {
        Bet = bet;
        MatchNo = matchNo;
    }


    public void AddGoal(int matchNo, bool isHomeTeam)
    {
        MatchArray(matchNo);
        //if (isHomeTeam) HomeGoals++;
        //else AwayGoals++;
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

    public static TwelveMatches[] MatchArray(int matchNo)
    {
        TwelveMatches[] result = new TwelveMatches[12];

        return result;
    }
}