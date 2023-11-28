using System;

namespace coins;

public class Class1
{
    public void Calculate(int amount)
    {
        var coinCountArray = CoinCountModels(amount);

        var sum = 0;
        for (int i = 0; i < coinCountArray.Length; i++)
        {
            var value = coinCountArray[i].value;
            var count = coinCountArray[i].count;
            var digit = value * count;
            sum += digit;
            Console.WriteLine(digit);
        };
        Console.WriteLine(sum+ " total");
    }

    private static CoinCountModel[] CoinCountModels(int amount = 0)
    {
        CoinCountModel[] coinCountArray = new CoinCountModel[]
        {
            new CoinCountModel { value = 1, count = amount },
            new CoinCountModel { value = 5, count = amount },
            new CoinCountModel { value = 10, count = amount },
            new CoinCountModel { value = 20, count = amount },
        };
        return coinCountArray;
    }
}