namespace _323C;

    public class Board
    {
        Square[] _squares = new Square[9];


        public Board()
        {
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        _squares[row, col] = new Square();
            //    }
            //}
        }
        public void Mark(string position)
        {
            int row = 0;
            int col = 0;

            if (position.Length >= 2)
            {
                col = position[0] - 'a';
                row = position[1]-1;
            }
        //_squares[row, col].SetSquareTaken(true, _squares[row, col]);
        }

        public Square GetSquare(int index)
        {
            return _squares[index];
        }
    }