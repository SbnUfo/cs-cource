using System;

namespace HW4
{
    enum Containers
    {
        OneL = 1,
        FiveL = 5,
        TwentyL = 20,
    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");
            double volume = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Containers[] bottles = (Containers[])Enum.GetValues(typeof(Containers));
            int[] NBottle = new int[bottles.Length];

            int ContainersFlags = 0;
            for (int i = bottles.Length - 1; i > 0; i--)
            {
                NBottle[i] = (int)volume / (int)bottles[i];
                if (NBottle[i] > 0)
                {
                    ContainersFlags |= 1 << i;
                    volume %= (int)bottles[i];
                }
            }

            NBottle[0] = (int)Math.Round(volume / (int)bottles[0]);
            if (NBottle[0] > 0)
                ContainersFlags |= 1;

            for (int i = bottles.Length - 1; i >= 0; i--)
            {
                if ((ContainersFlags & 1 << i) == 1 << i)

                    Console.WriteLine("Вам потребуются следующие контейнеры: {0,4:d} л: {1}шт.", bottles[i], NBottle[i]);

            }

        }
    }
}