using System;

namespace Course{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Calc;
            N = int.Parse(Console.ReadLine());
            for(int i=1; i <=10; i++)
            {
                Calc = i * N;
                Console.WriteLine(i +" x "+ N +" = "+Calc);
            }
        }
    }
}