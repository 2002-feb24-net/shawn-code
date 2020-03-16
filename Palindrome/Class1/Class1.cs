using System;
namespace Palindrome
{
    public class Class1
    {
        public bool CheckIfPalindrome(string str)
        {
            string rev;
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = str.Equals(rev, StringComparison.OrdinalIgnoreCase);
            return b;
        }
    }
}