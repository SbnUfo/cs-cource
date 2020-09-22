using System;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из нескольких слов: ");
            string[] WordsInSentence;
            var Counter = 0;
            while (true)
            {
                var Sentence = Console.ReadLine();
                WordsInSentence = Sentence.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (WordsInSentence.Length < 2) Console.WriteLine("Слишком мало слов, попробуйте ещё раз:");
                else break;
            }

            foreach (var Word in WordsInSentence)
            {
                if (Word.ToLower()[0].Equals('а'))
                    Counter++;
            }
            Console.WriteLine("Количество слов, начинающихся с буквы 'A': " + Counter);

        }

    }
}
