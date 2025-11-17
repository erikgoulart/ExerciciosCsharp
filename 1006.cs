using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, PesoA, PesoB, PesoC, Media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PesoA = 2;
            PesoB = 3;
            PesoC = 5;
            Media = (double) ((A*PesoA)+(B*PesoB)+(C*PesoC))/(PesoA+PesoB+PesoC);
            Console.WriteLine("MEDIA = "+ Media.ToString("F1", CultureInfo.InvariantCulture));  
        }
    }
}