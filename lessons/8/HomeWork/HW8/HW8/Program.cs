using System;
using System.Collections.Generic;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            var entered = Console.ReadLine();

            if (IsBool(entered)) Console.WriteLine("True");
            else Console.WriteLine("False");

        }

        static bool IsBool(string test)
        {
            var dictionary = new Dictionary<char, char>
            {
                { '(',')' },
                {'[',']' },
                {'{','}' },
                {'<','>' }
            };
            var stack = new Stack<char>();
            foreach (char i in test)
            {
                if (dictionary.ContainsKey(i))

                    stack.Push(i);

                else if (dictionary.ContainsValue(i))

                    stack.Pop();

            }
            return stack.Count == 0;
        }
    }
}