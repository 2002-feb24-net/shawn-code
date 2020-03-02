using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumFizz = 0;
            int NumBuzz = 0;
            int NumFizzBuzz = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    System.Console.WriteLine(i + " Fizz");
                    NumFizz++;
                }
                if (i % 3 != 0 && i % 5 == 0)
                {
                    System.Console.WriteLine(i + " Buzz");
                    NumBuzz++;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine(i + " FizzBuzz");
                    NumFizzBuzz++;
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.Write("Total Fizz = " + NumFizz + ' ');
            System.Console.WriteLine("Total Buzz = " + NumBuzz);
            System.Console.WriteLine("Total FizzBuzz = " + NumFizzBuzz);
            /* 
            FIZZ = 27 
            BUZZ = 14
            FIZZBUZZ = 6
            */
        }
    }
}