using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main (string [] args)
        {
            double a,b,c,d,e;
            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0], CultureInfo.InvariantCulture);
            b = double.Parse(v[1], CultureInfo.InvariantCulture);
            string[] v1 = Console.ReadLine().Split(' ');
            c = double.Parse(v1[0], CultureInfo.InvariantCulture);
            d = double.Parse(v1[1], CultureInfo.InvariantCulture);
            e = Math.Sqrt(Math.Pow((c-a),2)+ Math.Pow((d-b),2));
            Console.WriteLine(e.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}