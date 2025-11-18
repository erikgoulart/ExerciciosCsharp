using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,delta,xp,xm;
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            if (a > 0)
            {
                delta = Math.Pow(b,2)-4*a*c;
                if (delta > 0)
                {
                    xp = (-b+Math.Sqrt(delta))/(2.0*a);
                    xm = (-b-Math.Sqrt(delta))/(2.0*a);

                    Console.WriteLine("R1 = " + xp.ToString("F5", CultureInfo.InvariantCulture));
                    Console.WriteLine("R2 = " + xm.ToString("F5", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Impossivel Calcular");    
                }
            }
            else
            {
                Console.WriteLine("Impossivel Calcular");
            }


        }
    }
}