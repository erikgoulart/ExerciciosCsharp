using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor;
            string Intervalo;
            Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (Valor >= 0 && Valor<=25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            } 
            else if (Valor > 25.0 && Valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            } 
            else if (Valor > 50.0 && Valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (Valor > 75 && Valor <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");                
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

        }
    }
}