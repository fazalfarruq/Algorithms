using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSortAlgo
{
    public class MergeSort
    {

        public static int[] Merge(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return numbers;
            }

            decimal length = numbers.Length;
            int middle = Convert.ToInt16(Math.Floor(length / 2));

            var left = new int[middle];
            var right = new int[(int)length - middle];

            for (int i = 0; i <= middle - 1; i++)
            {

                left[i] = numbers[i];
            }

            for (int i = 0; i <= numbers.Length - middle - 1; i++)
            {
                var x = i + middle;
                right[i] = numbers[x];
            }

            var leftSort = Merge(left);
            var rightSort = Merge(right);

            var result = Stitch(leftSort, rightSort);
            return result;



        }

        private static int[] Stitch(int[] leftSort, int[] rightSort)
        {
            List<int> result = new List<int>();

            var leftStack = new LinkedList<int>(leftSort);
            var rightStack = new LinkedList<int>(rightSort);
            while (leftStack.Count > 0 && rightStack.Count > 0)
            {

                if (leftStack.ElementAt(0) < rightStack.ElementAt(0))
                {

                    result.Add(leftStack.ElementAt(0));
                    leftStack.RemoveFirst();
                }
                else
                {
                    result.Add(rightStack.ElementAt(0));
                    rightStack.RemoveFirst();
                }


            }

            while (leftStack.Count > 0)
            {

                result.Add(leftStack.ElementAt(0));
                leftStack.RemoveFirst();
            }

            while (rightStack.Count > 0)
            {

                result.Add(rightStack.ElementAt(0));
                rightStack.RemoveFirst();
            }

            return result.ToArray();
        }

        public static Tuple<int[], int[]> ArraySplitter(int[] numbers)
        {


            decimal length = numbers.Length;
            int middle = Convert.ToInt16(Math.Floor(length / 2));

            var left = new int[middle];
            var right = new int[(int)length - middle];

            for (int i = 0; i <= middle - 1; i++)
            {

                left[i] = numbers[i];
            }

            for (int i = 0; i <= numbers.Length - middle - 1; i++)
            {
                var x = i + middle;
                right[i] = numbers[x];
            }

            Tuple<int[], int[]> tuple = new Tuple<int[], int[]>(left, right);
            return tuple;

        }
    }
}
