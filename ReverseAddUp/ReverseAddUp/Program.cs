using System;
using System.Collections.Generic;

namespace ReverseAddUp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3 };
            var r = ReverseNumber(391);
            Console.WriteLine();
        }

        static List<int> ReverseUp(int[] numArrays)
        {
            List<int> result = new List<int>();
            var endIndex = numArrays.Length - 1;
            for (int i = 0; i < numArrays.Length; i++)
            {
                var begin = numArrays[i];
                var end = numArrays[endIndex];
                endIndex = endIndex - 1;
                result.Add(begin + end);

            }

            return result;
        }



        static int ReverseNumber(int number)
        {
            var reverse = 0;
            int lastDigit;
            while (number > 0)
            {
                lastDigit = number % 10;
                reverse = (reverse * 10) + lastDigit;
                number = number / 10;
            }

            return reverse;

        }

        public static int GetNumber(List<int> nums)
        {

            var array = nums.ToArray();
            var num = 0;
            var multiplier = 1;
            var t = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (multiplier == 1)
                {
                    t = array[i];
                }
                else
                {
                    t = multiplier * array[i];
                }

                num += t;
                multiplier = multiplier * 10;
            }

            return num;
        }
    }
}
