using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            char Resp;

            do
            {
                double C, F;
                Console.Write("Digite a Temperatura em Celcius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = (C * 1.8) + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: "+F.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Deseja Repetir? (s/n)");
                Resp = char.Parse(Console.ReadLine());
            } while(Resp == 's');
        }
    }
}