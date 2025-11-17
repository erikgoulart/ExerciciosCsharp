using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, a, b;
            double pi, vol,piv;
            pi = 3.14159;
            r = int.Parse(Console.ReadLine());
            piv = Math.Pow(r,3);
            vol = (4.0/3.0)*pi*piv;
            Console.WriteLine("VOLUME = "+ vol.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}