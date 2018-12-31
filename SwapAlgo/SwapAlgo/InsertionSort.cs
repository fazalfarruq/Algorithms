using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSortAlgo
{
    public class InsertionSort
    {
        public static int[] InsertSort(int[] array)
        {
            //this loop at the starting signifies that anything at the startg i.e array[0] is already sorted.. 
            //as we move up in the array with i++ we know that anything before it is already sorted...
            for (int i = 1; i < array.Length; i++)
            {
                Insert(array, i-1, array[i]);
            }
            return array;
        }


        //nums is the array
        //indexOnTheLeft is the index on the left where we start comparing with
        //key is the value that we want to compare with the value at indexOnTheLeft and insert it into the array accordingly when by going down the array from the rightIndex....
        // THE KEY TO THIS IS THAT IT 
        public static int[] Insert(int[] array, int indexOnTheLeft, int key)
        {

            for (var i = indexOnTheLeft; i >= 0; i--)
            {
                if (array[i] > key)
                {
                    array[i + 1] = array[i];
                    array[i] = key;
                }
            }

            return array;
        }
    }
}
