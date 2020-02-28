using System;
namespace TEST123
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Provide a string and a number: ");
            string UserInput = Console.ReadLine();
            if (UserInput.Contains(' ') == false)
            {
                Console.WriteLine("Invalid response, please try again.");
                Environment.Exit(0);
            }
            string[] VerifiedInput = UserInput.Split(' ');
            string str = VerifiedInput[0];
            int num = int.Parse(VerifiedInput[1]);
            for (int i = 1; i < str.Length; i++)
            {
                for (int start = 0; start <= str.Length - i; start++)
                {
                    string substr = str.Substring(start, i);
                    if (substr.Length == num)
                    {
                        Console.WriteLine(substr);
                    }
                }
            }
        }
    }
}