namespace coins;

    internal class CoinCountModel
    {
        private int _value;
        private int _count;

        public CoinCountModel(int value, int count)
        {
            _value = value;
            _count = count;
        }

        public int GetValue()
        {
            return _value * _count;
        }
    }
