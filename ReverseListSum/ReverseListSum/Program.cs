using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> list1 = new List<int>() { 7, 1, 6 };
        List<int> list2 = new List<int>() { 5, 9, 2 };

        var rev1 = ReverseOrder(list1);
        var rev2 = ReverseOrder(list2);
        var number1 = GetNumber(rev1);
        var number2 = GetNumber(rev2);

        var sum = number1 + number2;
        //sum.Dump();
        var temp = GetListOfNumbers(sum);
        var res = ReverseOrder(temp);

        Console.WriteLine();



    }


    private static List<int> ReverseOrder(List<int> numList)
    {

        List<int> reverseList = new List<int>();
        var array = numList.ToArray();
        foreach (var num in array.Reverse())
        {
            reverseList.Add(num);
        }

        return reverseList;


    }

    private static int GetNumber(List<int> nums)
    {

        var t = string.Empty;
        int number;
        foreach (var n in nums)
        {
            t += n.ToString();

        }

        var isParsed = int.TryParse(t, out number);
        return number;
    }

    private static List<int> GetListOfNumbers(int number)
    {

        var str = number.ToString().ToCharArray().Select(c => c.ToString());
        var result = new List<int>();
        result = str.Select(s => Convert.ToInt32(s)).ToList();
        return result;

    }
}