using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string [] args)
        {
            double x1, x2, x3;
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x3 = x1 + x2;
            Console.WriteLine("NOTA FINAL = "+ x3.ToString("F1", CultureInfo.InvariantCulture));
            if (x3 < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
