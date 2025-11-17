using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main (string [] args)
        {   
            double tri, cir, tra, qua, ret;
            string[] v = Console.ReadLine().Split(' ');
            double base1 = double.Parse(v[0], CultureInfo.InvariantCulture); 
            double base2 = double.Parse(v[1], CultureInfo.InvariantCulture); 
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            tri = (base1*altura)/2;
            cir = 3.14159*Math.Pow(altura,2);
            tra = ((base1+base2)*altura)/2;
            qua = Math.Pow(base2,2);
            ret = base1*base2;

            Console.WriteLine("TRIANGULO: "+tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+tra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ret.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}