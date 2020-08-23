using System;

namespace ConsoleAppHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter two numbers: ");
             double a = double.Parse(Console.ReadLine());
             double b = double.Parse(Console.ReadLine());
             Console.WriteLine("Sum: " + (a + b));
             Console.WriteLine("Difference: " + (a - b));
             Console.WriteLine("Product: " + (a * b));*/






            Console.WriteLine("Enter two numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
             

            
            Console.WriteLine("Specify the type of operation (+,-,*,/, %, ^): ");
            char o = char.Parse(Console.ReadLine());
            double r;

            if (o == '+')
            {
                r = a + b;
                Console.WriteLine("Result: " + r);
            }

            else if (o == '-')
            {
                r = a - b;
                Console.WriteLine("Result: " + r);
            }

            else if (o == '*')
            {
                r = a * b;
                Console.WriteLine("Result: " + r);
            }

            else if (o == '/')
            {
                r = a / b;
                Console.WriteLine("Result: " + r);
            }

            else if (o == '%')
            {
                r = a % b;
                Console.WriteLine("Result: " + r);
            }

           /* else if (o == '^')
            {
                r = a ^ b;
                Console.WriteLine("Result: " + r);
            }*/


        



        }
    }
}
