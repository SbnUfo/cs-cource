using System;

namespace CW11
{
    partial class Pet
    {
        public string Kind;
        public  string Name;
        public char Sex;
        public DateTimeOffset Date;

        public int Age()
        {
            return (int)((DateTimeOffset.Now - Date).TotalDays / ((365 * 4 + 366) / 5.0));
        }

        public void Uppdate(string name, DateTimeOffset date)
        {
            Name = name;
            Date = date;
        }

        public void Uppdate(string name, char sex)
        {
            Name = name;
            Sex = sex;

        }

        public void WriteProperties(bool showFullDescription = false)
        {
            if (showFullDescription)
            {
                Console.WriteLine(Deccription);
            }
            else
            {
                Console.WriteLine(ShortDeccription);
            }



        }

        
        public string ShortDeccription
        {

            get => $"Name: {Name} , Age :{ Date}";

        }
        public Pet(string kind, string name, char sex, DateTimeOffset date)
        {
            Kind = kind;
            Name = name;
            Sex = sex;
            Date = date;

        }

        

    }
   
}
