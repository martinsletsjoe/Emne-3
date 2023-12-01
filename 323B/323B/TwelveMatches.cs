using System.Text.RegularExpressions;

namespace _323B;

public class TwelveMatches
{
    public Match[] _matches;


    public TwelveMatches(string betsText)
    {
        var bets = betsText.Split(',');
        _matches = new Match[12];
        for (int i = 0; i < _matches.Length; i++)
        {
            _matches[i] = new Match(bets[i]);
        }

    }
    
    public void AddGoal(int matchNo, bool isHomeTeam)
    {
        var selectedIndex = matchNo - 1;
        var selectedMatch = _matches[selectedIndex];
        selectedMatch.AddGoal(isHomeTeam);
    }

    public void ShowAllScores()
    {
        for (int i = 0; i < _matches.Length; i++)
        {
            var match = _matches[i];
            var matchNo = i + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");

        }
    }

    public void ShowCorrectCount()
    {
        var correctCount = 0;
        foreach (var match in _matches)
        {
            if (match.IsBetCorrect()) correctCount++;
        }
        Console.WriteLine($"Du har {correctCount} rette.");
    }
}