using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSortAlgo
{
    public class SelectionSort
    {
        public static int[] SelectAndSort(int[] nums)
        {

            //for each index in the array one by one
            for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
            {
                //take the currenIndex/current position (starting at 0) in Array and compare it with the rest of the array on its right to find any index that is home to anything smaller
                int minIndex = FindMinIndex(nums, currentIndex);
                // now swap the currentIndex value with the one that is smaller 
                SwapValueInArray(nums, currentIndex, minIndex);

            }
            return nums;
        }

        private static void SwapValueInArray(int[] nums, int currentIndex, int minIndex)
        {
            var swapValue = nums[currentIndex];
            nums[currentIndex] = nums[minIndex];
            nums[minIndex] = swapValue;
        }

        public static int FindMinIndex(int[] nums, int startIndex)
        {
            var minValue = nums[startIndex];
            int minIndex = startIndex;
            //find the minimum index towards the right of the starting point..and keep going until we reach the end of the array...
            for (int j = startIndex + 1; j < nums.Length; j++)
            {

                if (minValue > nums[j])
                {
                    minValue = nums[j];
                    minIndex = j;

                }
            }
            return minIndex;
        }
    }
}
