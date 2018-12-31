using System;
using Xunit;
using SelectionSortAlgo;

namespace XUnitTestProject1
{
    public class SelectionSortTests
    {
        [Fact]
        public void FindMinimumShouldReturnMinIndex()
        {
            int[] numbers = { 4, 20, 10, 11, 3 };
            var minIndex = SelectionSort.FindMinIndex(numbers, 1);

            Assert.Equal(minIndex, 4);

        }
    }
}
