using System;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of several words: ");
            string[] words;
            while (true)
            {

                Console.Write("> ");
                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine("Вы ввели пустую строку, попробуйте ещё раз:");
                }
                else
                {
                    words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length < 2)
                    {
                        Console.WriteLine("Слишком мало слов, попробуйте ещё раз:");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
