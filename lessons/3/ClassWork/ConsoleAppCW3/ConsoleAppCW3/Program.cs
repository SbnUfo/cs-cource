using System;

namespace ConsoleAppCW3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* object a = 5;
             a = (int)a + 5;
             Console.WriteLine(a);
            dynamic b = 4;
            b = b + 5;
            Console.WriteLine(b);*/

            string[] values = new string[5];

            for (int i = 0; i < values.Length; i++) 
            {
                values[i] = Console.ReadLine();
            }

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }



            



        }
    }
}
