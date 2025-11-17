using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int D, Ano, Mes, Dia, RestoA, RestoM;
            D = int.Parse(Console.ReadLine());
            Ano = D/365;
            RestoA = D%365;
            Mes = RestoA/30;
            RestoM = RestoA%30;
            Dia = RestoM;
            Console.WriteLine(Ano+" ano(s)");
            Console.WriteLine(Mes+" mes(es)");
            Console.WriteLine(Dia+" dia(s)");
        }
    }
}