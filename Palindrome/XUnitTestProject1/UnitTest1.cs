using System;
using Xunit;
using Palindrome;
namespace XUnitTestProject1
{
    public class UnitTest1 : Class1
    {
        [Fact]
        public void Test1()
        {
            string TestString = "racecar";
            Assert.True(CheckIfPalindrome(TestString));
        }
    }
}