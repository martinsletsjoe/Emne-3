namespace _323C;

public class GameConsole
{
    public static void Show(Board b)
    {
        Console.WriteLine($@" 
    a b c
   ┌─────┐
  1│{txt(0,b)} {txt(1,b)} {tx}   │
  2│    o│
  3│× ×  │
   └─────┘");
    }

    public char txt(int index, Board board)
    {
        var square = board.GetSquare(index);
        if (square.IsEmpty()) return ' ';
        if (square.IsPlayer1()) return 'x';
        return 'o';
    }


}


