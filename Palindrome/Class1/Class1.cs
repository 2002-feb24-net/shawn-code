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
            if (b == true)
            {
                Console.WriteLine("" + str + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + str + " is not a Palindrome!");

            }
            return b;
        }
    }
}
