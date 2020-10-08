using System;

using System;

namespace Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminder1 = new ReminderItem(DateTimeOffset.Parse("10.10.2020 8:00"), "Будильник");
            Console.WriteLine(reminder1.WriteProperties());

            var reminder2 = new ReminderItem(DateTimeOffset.Parse("10.10.2020 8:10"), "Повторный будильник");
            Console.WriteLine(reminder2.WriteProperties());


        }
    }
}
