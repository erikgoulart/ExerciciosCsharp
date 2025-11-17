using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double v1, v2, tot;
            nome = Console.ReadLine();
            v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tot = v1+(v2*0.15);
            Console.WriteLine("TOTAL = R$ "+tot.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}