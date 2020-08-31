


using System;

namespace ConsoleAppCW
{
    enum Colors
    {
        Black = 0b1,
        Blue = 0b1 << 1,
        Cye = 0b1 << 2,
        Grey = 0b1 << 3,
        Green = 0b1 << 4,
        Magenta = 0b1 << 5,
        Red = 0b1 << 6,
        White = 0b1 << 7,
        Yellow = 0b1 << 8
    }
    class Program
    {  

        static void Main(string[] args)
        {
            Console.WriteLine("Choose 4 colors");
            var a = (Colors[])(Enum.GetValues(typeof(Colors)));
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }
            for (int i = 0; i < 4; i++)
            {
                Colors color = (Colors)Enum.Parse(typeof(Colors), Console.ReadLine());
                Colors =

            }
           





            /*Console.WriteLine("Введите значения для a");
            var fN = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значения для h");
            var SN = int.Parse(Console.ReadLine());

            var H  = Math.Sqrt(Math.Pow(SN, 2) - (Math.Pow(fN, 2) / 12));

            Console.WriteLine("S side = " + (3 * fN * SN));

            Console.WriteLine("S full = " + (3.0/2) * fN * (fN * Math.Sqrt(3) + 2*SN));

            Console.WriteLine("V = " +Math.Pow(fN, 2) /2 * H +Math.Sqrt(3));

            Console.WriteLine(H);*/


        }
    }
}
