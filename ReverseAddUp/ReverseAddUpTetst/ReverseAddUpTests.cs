using ReverseAddUp;
using System;
using System.Collections.Generic;
using Xunit;

namespace ReverseAddUpTetst
{
    public class ReverseAddUpTests
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 9,5,2,6,5 };
            var num = Program.GetNumber(list);

            Assert.Equal(95265, num);

        }
    }
}
