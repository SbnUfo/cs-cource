using System;

namespace HW7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите непустую строку:");

            while (true)
            {
                var Line = Console.ReadLine().ToLower();

                if (Line.Length < 1) Console.WriteLine("Вы ввели пустую строку:( Попробуйте ещё раз:");

                else
                {
                    char[] ReverseLine = Line.ToCharArray();
                    Array.Reverse(ReverseLine);
                    string output = new string(ReverseLine);
                    Console.WriteLine(ReverseLine);

                }


            }

        }

    }
}


