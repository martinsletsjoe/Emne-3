namespace _323C;

public class GameConsole
{
    private Board _board;

    public GameConsole(Board board)
    {
        _board = board;
    }
    public void Show(object board)
    {
        Console.Clear();
        Console.WriteLine(@"
                a b c
               ┌─────┐
              1│o    │
              2│    o│
              3│× ×  │
               └─────┘");
    }
}


