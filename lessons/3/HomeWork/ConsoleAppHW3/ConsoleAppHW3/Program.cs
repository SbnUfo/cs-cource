using System;

namespace ConsoleAppHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three names: ");
            string[] names = new string[3];
                names[0] = Console.ReadLine();
                names[1] = Console.ReadLine();
                names[2] = Console.ReadLine();

            
            Console.WriteLine("Enter age of these people: ");
            string[] age = new string[3];
            age[0] = Console.ReadLine();
            age[1] = Console.ReadLine();
            age[2] = Console.ReadLine();

 
            for (int i = 0; i < names.Length; i++)
            {
                int a = int.Parse(age[i]) + 4;
                Console.WriteLine("Name: " + (names[i]) + ", age in 4 years: "+ (a));
            }


        }
    }
    
}
