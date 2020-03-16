using System;

namespace Test123
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = {"One", "Two", "Three"};
            System.Console.WriteLine(words[2].Substring(0,1));
            /*
                OR
                words[2][0];
            */
        }
    }
}
