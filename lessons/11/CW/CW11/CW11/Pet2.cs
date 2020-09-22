using System;
using System.Collections.Generic;
using System.Text;

namespace CW11
{
    partial class Pet
    {
        public string Deccription
        {
            get => $"Kind:{Kind}, Name: {Name} , Sex{Sex}, Age :{ Date}";

        }
    }
}
