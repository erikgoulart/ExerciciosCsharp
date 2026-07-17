using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Contador;
            Contador = 0;
            double Soma = 0.0;
            X = int.Parse(Console.ReadLine());
            if(X > 0){
                while (X > 0)
                {
                    Soma += X;
                    Contador += 1;
                    X = int.Parse(Console.ReadLine());
                }
                double ValorFinal = Soma/Contador;
                Console.WriteLine(ValorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossivel Calcular");
            }
        }
    }
}