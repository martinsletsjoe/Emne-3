namespace _323C;

public class Square
{
    private bool CheckIfEmpty(Taken value)
    {
        return value == Taken.Empty;
    }

    public bool IsPlayer1(Taken value)
    {
        return value == Taken.Player1;
    }

    public void SetSquareTaken(bool player1, Taken value)
    {
        if (!CheckIfEmpty(value))
        {
            Console.WriteLine("The square is not empty");
            return;
        }

        if (player1)
        {
            Console.WriteLine($"This square is now taken by {Taken.Player1}");
        }
        else
        {
            Console.WriteLine($"This square is now taken by {Taken.Player2}");
        }
    }
}