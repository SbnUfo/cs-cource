using System;
using System.Collections.Generic;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            var PersonsList = Information(3);

            foreach (var person in PersonsList)
                Console.WriteLine(person.PersonInfo);

            Console.WriteLine("Press any key to continue..");
        }

        static List<Person> Information(int count)
        {
            var PersonsList = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string name;
                int age;


                Console.WriteLine($"Enter name {i}:");
                while (true)
                {
                    name = Console.ReadLine();

                    if (!string.IsNullOrEmpty(name))
                        break;

                    Console.WriteLine("Input Error! Please, try again:");
                }


                Console.WriteLine($"Enter age {i}:");

                var result = int.TryParse(Console.ReadLine(), out age);


                PersonsList.Add(new Person(name, age));
            }

            return PersonsList;
        }
    }

    class Person
    {
        public string PersonName { get; set; }
        public int PersonAge { get; set; }

        public int AgeIn4Years =>
            (byte)(PersonAge + 4);

        public string PersonInfo =>
            $"Name: {PersonName}, age in 4 years: {AgeIn4Years}";

        public Person(string personName, int personAge)
        {
            PersonName = personName;
            PersonAge = personAge;
        }
    }
}