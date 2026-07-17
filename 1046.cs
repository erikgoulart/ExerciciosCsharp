using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inicio, Fim, Horas;
            string[] vet = Console.ReadLine().Split(' ');
            Inicio = int.Parse(vet[0]);
            Fim = int.Parse(vet[1]);

            if (Inicio<Fim)
            {
                Horas = Fim-Inicio;
            } else if (Inicio>Fim){
                Horas=(24-Inicio)+Fim;
            }
            else
            {
                Horas = 24;
            }
            Console.WriteLine("O JOGO DUROU "+ Horas + " HORA(S)");
        }
    }
}