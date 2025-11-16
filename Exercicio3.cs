using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            string[] vet1 = Console.ReadLine().Split(' ');
            string nome1 = vet1[0];
            int idade1 = int.Parse(vet1[1]);
            double X = (double) (idade+idade1)/2;
            Console.WriteLine("A idade média de "+ nome +" e "+nome1+" é de "+X.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }
    }
}