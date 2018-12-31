using System;
using Xunit;
using IsPalindrome;

namespace IsPalindromeTests
{
    public class IsPalinDromeTests
    {
        [Fact]
        public void GetFirstLetterShouldReturnTheFirstLetterFromAString()
        {
            string str = "Test";
            var result = Program.GetFirstLetter(str);

            Assert.Equal("T", result);

            string str2 = "F";
            var result2 = Program.GetFirstLetter(str2);
            Assert.Equal("F", result2);
        }

        [Fact]
        public void GetLastLetterShouldReturnTheLastLetterFromAString()
        {

            string str1 = "Samiya";
            var result1 = Program.GetLastLetter(str1);
            Assert.Equal("a", result1);


            string str2 = "Fazal";
            var result2 = Program.GetLastLetter(str2);
            Assert.Equal("l", result2);
        }

        [Fact]
        public void GetMiddleStringShouldReturnTheMiddleLettersFromAString()
        {

            string str1 = "Samiya";
            var result1 = Program.GetMiddleString(str1);
            Assert.Equal("amiy", result1);

            string str2 = "Fazal";
            var result2 = Program.GetMiddleString(str2);
            Assert.Equal("aza", result2);

        }

        [Fact]
        public void IsPalindromeShouldReturnTrueWhenAStringIsAPalidrome()
        {

            var str = "rotor";
            Assert.True(Program.IsPalidrome(str));
        }

        [Fact]
        public void IsPalindromeShouldReturnFalseWhenAStringIsNotAPalidrome()
        {

            var str = "fazal";
            Assert.False(Program.IsPalidrome(str));
        }


        [Fact]
        public void SimpleReducedStringShouldReturnSmallString()
        {

            //var str = "aaabccddd";
            //var s = Program.SimpleReducedString(str);
            //Assert.Equal("abd", s);


            //var str1 = "baab";
            //var s1 = Program.SimpleReducedString(str1);
            //Assert.Equal("", s1);

            var str2 = "aa";
            var s2 = Program.SimpleReducedString(str2);
            Assert.Equal("", s2);
        }
    }
}
