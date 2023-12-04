namespace _323C;

public class GameConsole
{
    private Board _board;

    public GameConsole(Board board)
    {
        _board = board;
    }
    public void Show(Board board)
    {
        Console.WriteLine($@"  a b c
   ┌─────┐
  1│{}    │
  2│    o│
  3│× ×  │
   └─────┘");
    }

    public char GetChar(int index, Board board)
    {
        var square = board.GetSquare(index);
        if (square == "x")
        {
            
        }
    }


}


