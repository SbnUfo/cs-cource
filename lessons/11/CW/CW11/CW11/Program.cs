using System;
namespace CW11
{
    class programm
    {
        public static void Main()
        {
            var pet = new Pet("Dog", "An", 'F', DateTimeOffset.Parse("05/01/2009"));
            
            pet.WriteProperties();


        }
    }
}
