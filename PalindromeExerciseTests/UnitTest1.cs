using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("palindrome",true)]
        [InlineData("paLindroMe", true)]
        [InlineData("Palindrome", true)]
        [InlineData("random", false)]
        [InlineData("1398", false)]
        public void Test1(string word, bool expected)
        {
            var wordSmit = new WordSmith();

        var actual = wordSmit.IsAPalindrome(word);
            Assert.Equal(expected, actual);





    }
    }
}
