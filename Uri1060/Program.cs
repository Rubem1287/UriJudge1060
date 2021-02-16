using System;

namespace Uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, cont;

            cont = 0;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            e = double.Parse(Console.ReadLine());
            f = double.Parse(Console.ReadLine());

            if(a >=0)
            {
                cont += +1;
            }

            if (b >= 0)
            {
                cont += +1;
            }

            if (c >= 0)
            {
                cont += +1;
            }

            if (d >= 0)
            {
                cont += +1;
            }

            if (e >= 0)
            {
                cont += +1;
            }

            if (f >= 0)
            {
                cont += +1;
            }

            Console.WriteLine();
            Console.WriteLine(cont + " Valores positivos");

        }
    }
}
