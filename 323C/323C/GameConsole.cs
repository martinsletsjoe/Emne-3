namespace _323C;

public class GameConsole
{
    public static void Show(Board board)
    {
        Console.WriteLine($@" 
    a b c
   ┌─────┐
  1│o    │
  2│    o│
  3│× ×  │
   └─────┘");
    }

    //public char GetChar(int index, Board board)
    //{
    //    var square = board.GetSquare(index);
    //    if (square == "x")
    //    {
            
    //    }
    //}


}


