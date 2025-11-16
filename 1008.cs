using System;
using System.Globalization;

namespace Course{

    class Program
    {
        static void Main(string [] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double S = B*C;

            Console.WriteLine("NUMBER = " + A);
            Console.WriteLine("SALARY = U$ "+ S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}