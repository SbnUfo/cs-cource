using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = EnterNumber();
            var quantity = 0;

            var Number = number;

            while (Number > 0)
            {
                if (Number % 10 % 2 == 0)
                    quantity++;
                Number /= 10;
            }
            Console.WriteLine("В числе " + number + " содержится " + quantity + " четных цифр.");

        }


        static int EnterNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите положительное натуральное число не более 2 миллиардов: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number > 0)
                        return number;
                    Console.WriteLine("Ошибка! Введите значение больше нуля.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.GetType() + "; Попробуйте ещё раз:");
                }
            }
        }



    }
}

