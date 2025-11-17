using System;

namespace Course
{
    class Program
    {
        static void Main(string [] args)
        {
            int X, Y, km;
            km = int.Parse(Console.ReadLine());
            X = 60;
            Y = 90;
            double temp = km/((Y-X)/60.0);
            Console.WriteLine(temp+" minutos");
        }
    }
}