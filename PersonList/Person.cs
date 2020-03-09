using System;

namespace PersonList
{
    class Person
    {
        /*
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }*/
        private string Name { get; set; }
        private int Age { get; set; }




        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            if (String.IsNullOrEmpty(name))
            {
                System.Console.WriteLine("Name is required");
                Environment.Exit(0);
            }
        }
        public override string ToString()
        {
            return String.Concat("Name: ", Name," Age: ", Age);
        }

    }
}