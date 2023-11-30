namespace StatsWithEncapsulation
{
    internal class Stats
    {
        public int NumberCount { get; private set; }
        public int Sum { get; private set; }

        public float Mean => (float)Sum / NumberCount;
        public void AddNumber(int number)
        {
            Sum = number;
            NumberCount++;
        }
    }
}
