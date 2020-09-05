using System;

namespace HW5
{
    public enum Figurs { circle = 1, triangle = 2, rectangle = 3 }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Select a shape type(1-circle, 2-triangle, 3-rectangle): ");
                Figurs c = (Figurs)Enum.Parse(typeof(Figurs), Console.ReadLine());

                switch (c)
                {
                    case Figurs.circle:
                        Console.WriteLine("Indicate circle's diameter: ");
                        double d = double.Parse(Console.ReadLine());
                        double S = Math.PI * Math.Pow(d, 2);
                        double P = 2 * Math.PI * (d / 2);
                        Console.WriteLine("Surface area= " + P + ", Perimeter length= " + S);
                        break;

                    case Figurs.triangle:
                        Console.WriteLine("Indicate side length triangle's: ");
                        double l = double.Parse(Console.ReadLine());
                        double s = ((Math.Sqrt(3) / 4) * Math.Pow(l, 2));
                        double p = l * 3;
                        Console.WriteLine("Surface area= " + p + ", Perimeter length= " + s);
                        break;

                    case Figurs.rectangle:
                        Console.WriteLine("Indicate width and height rectangle's: ");
                        double w = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        double ss = w * h;
                        double pp = (w + h) * 2;
                        Console.WriteLine("Surface area= " + pp + ", Perimeter length= " + ss);
                        break;
                }

            }
            catch (FormatException e) 
            {
                Console.WriteLine("You entered wrong data!");
            }
            finally
            {
                Console.WriteLine("Try again");
            }



        }
    }
}
