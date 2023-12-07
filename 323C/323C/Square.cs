namespace _323C;

public class Square
{
    private Taken _content;

    // Overtydelig
    public Square()
    {
        _content = Taken.Empty;
    }

    public bool IsEmpty()
    {
        return _content == Taken.Empty;
    }

    public bool IsPlayer1()
    {
        return _content == Taken.Player1;
    }

    public void SetSquareTaken(bool isPlayer1)
    {
        _content = isPlayer1 ? Taken.Player1 : Taken.Player2;
    }
}