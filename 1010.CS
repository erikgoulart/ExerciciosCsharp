using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main (string [] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet [0]);
            int B = int.Parse(vet [1]);
            double C = double.Parse(vet [2], CultureInfo.InvariantCulture);
            string[] vet1 = Console.ReadLine().Split(' ');
            int D = int.Parse(vet1 [0]);
            int E = int.Parse(vet1 [1]);
            double F = double.Parse(vet1 [2], CultureInfo.InvariantCulture);
            double Pagar = B*C+E*F;
            Console.WriteLine("VALOR A PAGAR: R$ "+Pagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}