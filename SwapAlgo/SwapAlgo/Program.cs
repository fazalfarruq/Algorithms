using SelectionSortAlgo;
using System;

namespace SelectionSortAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 14, 7, 3, 12, 9, 11, 6, 2 };

            Console.WriteLine("Hello World!");
            var t = QuickSort.Pivitor(numbers);
            //var ts = BubbleSortAlgo.DoSwap(numbers);
            //var result = InsertionSort.InsertSort(numbers);
            Console.ReadKey();

        }




    }
}
