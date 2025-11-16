using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main (string [] args)
        {
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Area = X * Y;
            double Perimetro = 2*X+2*Y;
            double Diagonal = Math.Sqrt(Math.Pow(Y, 2.0)+Math.Pow(X,2.0));
            Console.WriteLine("AREA = "+ Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = "+ Diagonal.ToString("F4", CultureInfo.InvariantCulture));
        } 
    }
}