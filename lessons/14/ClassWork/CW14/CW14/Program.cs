using System;
using System.Collections;
using System.Collections.Generic;

namespace CW14
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var a = new ErrorList("test1", new List<string> { "testerror1", "testerror2" }))
                Console.WriteLine($"Category: {a.Category}, Errors: {a.Errors}");

            foreach(var item in a)
            {

            }

        }
    }

    class ErrorList : IDisposable, IEnumerable<string>
    {
        public string Category { get; }

        public List<string> Errors { get; set; }

        public ErrorList(string category, List<string> errors)
        {
            Category = category;
            Errors = errors;
        }
        public void Add(string errorMessage)
        {
            Errors.Add($"{errorMessage} {Category}");
        }
        public IEnumerator<string> GetEnumerator()
        {
            return Errors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Errors.GetEnumerator();
        }
        public void Dispose()
        {
            if (Errors == null)
            {
                return;
            }
            Errors.Clear();
            Errors = null;
        }
    }
}

