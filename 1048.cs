using System;
using System.Globalization;

namespace Course{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario, NewSalario, Reajuste, Porcentagem;
            Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Salario >= 0 && Salario <= 400.0)
            {
                Porcentagem = 15;
                Reajuste = Salario*0.15;

            } else if (Salario >= 400.01 && Salario <= 800.0)
            {
                Porcentagem = 12;
                Reajuste = Salario*0.12;
            } else if (Salario >= 800.01 && Salario <= 1200.0)
            {
                Porcentagem = 10;
                Reajuste = Salario*0.10;
            } else if (Salario >= 1200.01 && Salario <= 2000.0)
            {
                Porcentagem = 7;
                Reajuste = Salario*0.07;
            } else
            {
                Porcentagem = 4;
                Reajuste = Salario*0.04;
            }
            NewSalario = Salario+Reajuste;
            Console.WriteLine("Novo salario: "+ NewSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+Reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: "+Porcentagem+" %");
        }
    }
}