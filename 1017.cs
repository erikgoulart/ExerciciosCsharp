using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string [] args)
        {
            int V, T;
            T = int.Parse(Console.ReadLine());
            V = int.Parse(Console.ReadLine());
            double L = (double) (T*V)/12;
            Console.WriteLine(L.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}