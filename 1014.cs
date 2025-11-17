using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string [] args)
        {
            int X;
            double Y, km;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            km = (double) X/Y;
            Console.WriteLine(km.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}