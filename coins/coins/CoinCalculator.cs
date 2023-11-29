﻿using System;

namespace coins;

internal class CoinCalculator
{
    public void run()
    {
        Calculate();
    }

    private void Calculate()
    {
        var coinCountArray = GetCoinCountArray();

        var totalValue = 0;
        foreach (var coinCount in coinCountArray)
        {
            totalValue += coinCount.GetValue();
        };

    }

    private static CoinCountModel[] GetCoinCountArray()
    {
        CoinCountModel[] coinCountArray = new CoinCountModel[]
        {
            new CoinCountModel(1, 7),
            new CoinCountModel(5, 3),
            new CoinCountModel(10, 2),
            new CoinCountModel(20, 11),
            //new CoinCountModel { value = 1, count = 7 },
            //new CoinCountModel { value = 5, count = 3 },
            //new CoinCountModel { value = 10, count = 2 },
            //new CoinCountModel { value = 20, count = 11 },
        };
        return coinCountArray;
    }
}