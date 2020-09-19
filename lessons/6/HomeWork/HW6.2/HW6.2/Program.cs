using System;

namespace HW6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            var contribution = EnterNumber();
            var persent = EnterNumber();
            var stockpiling = EnterNumber();
            var counterDays = 0;

            var Contribution = contribution;
            var Persent = persent;
            var Stockpiling = stockpiling;


            while (Contribution > 0)
            {
                if (Contribution <= Stockpiling)
                    counterDays++;
                Contribution = Contribution * Persent + Contribution;

            }
            Console.WriteLine("Вам необходимо " + counterDays + " дней для накопления суммы.");
        }
        static double EnterNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сумму первоначального взноса в рублях:");
                    var contribution = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01):");
                    var persent = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите желаемую сумму накопления в рублях:");
                    var stockpiling = double.Parse(Console.ReadLine());

                    if (contribution <= 0)

                    {
                        Console.WriteLine("Ошибка! Введите значение больше нуля.");
                        continue;
                    }
                   else if (contribution > 0)
                        return contribution;

                    if (persent <= 0)

                    {
                        Console.WriteLine("Ошибка! Введите значение больше нуля.");
                        continue;
                    }
                    else if (persent > 0)
                    return persent;

                    if (stockpiling <= 0)

                    {
                        Console.WriteLine("Ошибка! Введите значение больше нуля.");
                        
                    }
                    else if (stockpiling > 0)
                    return stockpiling;
                    break;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.GetType() + "; Попробуйте ещё раз:");

                }
            }
        }
    }
}

