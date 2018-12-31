using System;
using Xunit;
using SelectionSortAlgo;

namespace XUnitTestProject1
{
    public class InsertionSortTest
    {
        [Fact]
        public void InsertShouldInsertTheKeyToTheLeft()
        {
            int[] numbers = { 3, 5, 7, 11, 13, 2, 9, 6};
            var rightIndex = 4;
            var key = 2;
            var nums = InsertionSort.Insert(numbers, rightIndex, key);

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13, 9, 6 }, nums);


        }
    }
}
