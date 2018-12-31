using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSortAlgo
{
    public class QuickSort
    {

        public static int[] Pivitor(int[] array)
        {

            if (array.Length < 2)
            {
                return array;
            }

            int pivot = array[array.Length - 1];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < pivot)
                {
                    left.Add(array[i]);
                }

                if (array[i] > pivot)
                {
                    right.Add(array[i]);
                }

            }
            var leftSort = Pivitor(left.ToArray());
            var rightSort = Pivitor(right.ToArray());

            var result = Stitch(leftSort, rightSort, pivot);
            return result;
        }


        private static int[] Stitch(int[] leftSort, int[] rightSort, int pivot)
        {
            List<int> result = new List<int>();

            var leftStack = new LinkedList<int>(leftSort);
            var rightStack = new LinkedList<int>(rightSort);

            //we always add the pivot at the end of the leftStack....

            if (leftStack.Count == 0)
            {
                result.Add(pivot);
            }
            else
            {
                while (leftStack.Count > 0)
                {

                    result.Add(leftStack.ElementAt(0));
                    leftStack.RemoveFirst();

                }
                result.Add(pivot);
            }

            while (rightStack.Count > 0)
            {
                result.Add(rightStack.ElementAt(0));
                rightStack.RemoveFirst();
            }

            return result.ToArray();
        }

        public static Tuple<int[], int[]> SimplePivitor(int[] array)
        {

            int pivot = array[array.Length - 1];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < pivot)
                {
                    left.Add(array[i]);
                }

                if (array[i] > pivot)
                {
                    right.Add(array[i]);
                }

            }

            Tuple<int[], int[]> result = new Tuple<int[], int[]>(left.ToArray(), right.ToArray());

            return result;
        }
    }
}
