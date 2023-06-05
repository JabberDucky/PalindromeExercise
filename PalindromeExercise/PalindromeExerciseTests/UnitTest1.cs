using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mushroom", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordsmith = new WordSmith();

            //Act
            var actual = wordsmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
