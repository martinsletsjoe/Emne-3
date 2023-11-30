using System;

namespace coins;

internal class CoinCalculator
{
    public void run()
    {
        Calculate();
    }

    private void Calculate()
    {
        var coinCountArray = CoinCountModel.GetCoinCountArray();

        var totalValue = 0;
        foreach (var coinCount in coinCountArray)
        {
            totalValue += coinCount.GetValue();
        };
        Console.WriteLine(totalValue);

    }

}