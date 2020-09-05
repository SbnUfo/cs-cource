


using System;

namespace ConsoleAppCW
{
    // Используем short, т.к. цветов больше 9,
    // значит, не влезаем в диапазон byte

    // В квадратных скобочках указан атрибут. 
    // Что такое атрибуты , мы пока не изучали. 
    // Но сейчас, достаточно запомнить, что это специальные методанные для типа.
    // Например, если указан атрибут Flags для перечисления, то его методы, такие как ToString()
    // Самостоятельно воспринимают значение перечисления как набор флагов и выводят набор цветов на экран.
    // Если убрать этот атрибут, вместо читаемых надписей в консоли, будет указано просто число. 
    [Flags]
    enum Colors : short
    {
        // Часто используется специальное фиктивное значение (Default/None) равное нулю
        // Далее, каждое значение флага инициализируется с помощью двоичных литералов
        // Никто не запрещает инициализировать значения флагов
        // с помощью шестнадцатеричных литералов (0x01, 0x02, 0x04, 0x08, 0x10 и тд)
        // Или с помощью десятичных цифр (1, 2, 4, 8, 16, 32, 64 и тд)
        None = 0b0000000000000000, // 0       0
        Black = 0b0000000000000001, // 1       0x1
        Blue = 0b0000000000000010, // 1 << 1  0x2
        Cyan = 0b0000000000000100, // 1 << 2  0x4
        Grey = 0b0000000000001000, // 1 << 3  0x8
        Green = 0b0000000000010000, // 1 << 4  0x10
        Magenta = 0b0000000000100000, // 1 << 5  0x20
        Red = 0b0000000001000000, // 1 << 6  0x40
        White = 0b0000000010000000, // 1 << 7  0x80
        Yellow = 0b0000000100000000, // 1 << 8  0x100
    }

    class Program
    {
        static void Main()
        {
            var allColors = Colors.None;
            var names = Enum.GetNames(typeof(Colors));
            for (var i = 0; i < names.Length; i++)
            {
                allColors |= (Colors)(1 << i);
            }

            var favoriteColors = Colors.None;
            for (var i = 0; i < 4; i++)
            {
                favoriteColors |= ReadColor($"Enter the {i + 1} favorite color: ");
            }

            Console.WriteLine($"Favorite colors: {favoriteColors}");
            Console.WriteLine($"Reminder colors: {allColors ^ favoriteColors}");
        }

        static Colors ReadColor(string title)
        {
            for (; ; )
            {
                Console.Write(title);

                // Про серию методов *.TryParse еще поговорим. 
                // Но вкратце, эти методы возвращают bool, как признак, удалось ли выполнить парсинг
                // А само преобразованное значение передают через аргументы (out variables)
                if (Enum.TryParse(typeof(Colors), Console.ReadLine(), out var color))
                {
                    return (Colors)color;
                }

                Console.WriteLine("Wrong value specified!");


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
}
