using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pesoA = 3.5;
            double pesoB = 7.5;
            double Media = ((A*pesoA)+(B*pesoB))/(pesoA+pesoB);
            Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}