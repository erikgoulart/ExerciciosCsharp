using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int n100, n50, n20, n10, n5, n2, n1;
            valor = int.Parse(Console.ReadLine());
            n100 = valor/100;
            int resto100 = valor % 100;

            n50 = resto100/50;
            int resto50 = resto100 % 50;

            n20 = resto50/20;
            int resto20 = resto50 % 20;

            n10 = resto20/ 10;
            int resto10 = resto20 % 10;

            n5 = resto10/5;
            int resto5 = resto10%5;

            n2 = resto5/2;
            int resto2 = resto5 % 2;

            n1 = resto2;

            Console.WriteLine(valor);
            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");
        }
    }
}