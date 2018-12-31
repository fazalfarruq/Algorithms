using System;
using Xunit;
using SelectionSortAlgo;

namespace XUnitTestProject1
{
    public class MergeSortTests
    {
        [Fact]
        public void SplitterShouldSplitArraysWithEvenNumberOfElements()
        {
            int[] numbers = { 4, 20, 10, 11, 3, 15, 22, 26 };
            var result = MergeSort.ArraySplitter(numbers);

            Assert.Equal(new int[] { 4, 20, 10, 11 }, result.Item1);
            Assert.Equal(new int[] { 3, 15, 22, 26 }, result.Item2);


            int[] numbers1 = { 15, 3, 25, 22, 6 };
            var result1 = MergeSort.ArraySplitter(numbers1);

            Assert.Equal(new int[] { 15, 3 }, result1.Item1);
            Assert.Equal(new int[] { 25, 22, 6 }, result1.Item2);

        }


        [Fact]
        public void SplitterShouldSplitArraysWithOddNumberOfElements()
        {
            int[] numbers1 = { 15, 3, 25, 22, 6 };
            var result1 = MergeSort.ArraySplitter(numbers1);

            Assert.Equal(new int[] { 15, 3 }, result1.Item1);
            Assert.Equal(new int[] { 25, 22, 6 }, result1.Item2);

        }
    }
}
