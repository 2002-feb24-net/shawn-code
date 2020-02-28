using System;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please provide more than 1 word: ");
            String UserInput = Console.ReadLine();
            string Acronym = Abbreviate(UserInput);
            System.Console.WriteLine(Acronym);
        }
        public static string Abbreviate(string UserInput)
        {
            string[] FullString = UserInput.Split(new char[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string UpperCaseLetters = "";
            foreach (string word in FullString)
            {
                UpperCaseLetters += word[0].ToString().ToUpper();
            }
            return UpperCaseLetters;
        }
    }
}
