using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine(" Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:");
            Console.WriteLine("Entre com seu Nome Completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quanto quartos tem na sua sala?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");
            string [] vet = Console.ReadLine().Split(' ');
            string nomev = vet[0];
            int idadev = int.Parse(vet[1]);
            double alturav = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nomev);
            Console.WriteLine(idadev);
            Console.WriteLine(alturav.ToString(CultureInfo.InvariantCulture));
        }
    }
}