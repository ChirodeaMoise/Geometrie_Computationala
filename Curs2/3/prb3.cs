using System;

namespace problema_3
{
    class prb3
    {
        static void Main(string[] args)
        {
            //PROBLEMA 3
            Console.WriteLine("Valori vector 1: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valori vector 2: ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valori vector 3: ");
            double i = int.Parse(Console.ReadLine());
            double j = int.Parse(Console.ReadLine());
            double k = int.Parse(Console.ReadLine());

            double prodMixt = x1 * y2 * k + y1 * z2 * i + z1 * x2 * j - z1 * y2 * i - y1 * x2 * k - x1 * z2 * j;
            double volum = Math.Abs(prodMixt);
            if (prodMixt == 0)
            {
                Console.WriteLine("produs =" + prodMixt);
                Console.WriteLine("volum = 0");
                Console.WriteLine("coplanari");
                Console.WriteLine("coplanari");
            }
            else
            {
                Console.WriteLine("produs =" + prodMixt);
                Console.WriteLine("volum = " + volum);
                Console.WriteLine("nu sunt coplanari");
            }
        }
    }
}
