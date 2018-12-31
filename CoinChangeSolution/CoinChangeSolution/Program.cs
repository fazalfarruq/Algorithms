using System;
using System.Collections.Generic;
using System.Linq;

class GFG
{
    public static void Main()
    {

        List<int> denom = new List<int> { 1, 2, 3 };
        var ts = denom.Select(t => t).AsQueryable<int>();
        var tf = GetChange(5, ts);
        Console.WriteLine();


    }

    public static IEnumerable<List<int>> GetChange(int target, IQueryable<int> coins)
    {
        var availableCoins = from c in coins where c <= target select c;
        if (!availableCoins.Any())
        {
            yield return new List<int>();
        }
        else
        {
            foreach (var thisCoin in availableCoins)
            {
                var results = GetChange(target - thisCoin, from c in availableCoins where c <= thisCoin select c);
                foreach (var result in results)
                {

                    result.Add(thisCoin);
                    yield return result;
                }
            }
        }
    }

    
}