using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSortAlgo
{
    public class BubbleSort
    {

        public static int[] DoSwap(int[] nums)
        {
            var swapped = false;
            //outer loop to go through all the numbers until all are sorted and none of them are swapped
            //this loop has to run atleast once to check if there is nothing to sort..
            do
            {
                swapped = false;
                // inner loop to compare and swap the numbers if they are out of order
                for (int i = 0; i < nums.Length -1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        var temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);

            return nums;
        }
    }
}
