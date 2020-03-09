using System;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Shawn", 27);
            var person2 = new Person("Ted", 22);
            var person3 = new Person("Ralph", 43);
            var person4 = new Person("Samuel", 19);
            var person5 = new Person("Edgar", 25);
            System.Console.WriteLine(person1.ToString());
            System.Console.WriteLine(person2.ToString());
            System.Console.WriteLine(person3.ToString());
            System.Console.WriteLine(person4.ToString());
            System.Console.WriteLine(person5.ToString());

            //add names to list
            //check list for duplicates
            //insertion sort


            /*
            Bubble sort compares two adjacent items,
            and swaps them if not in order,
            repeating until complete
            */

            /*
            Merge sort breaks down until everything is 1 element,
            and then sorts them at the end
            */

            /*
            My old apartment just emailed me about owing them a lot of money
            for plumbing issues that didn't exist when I left,
            I'm stressing too much over it, 
            sorry if I missed parts of this assignment
            */




        }
    }
}
