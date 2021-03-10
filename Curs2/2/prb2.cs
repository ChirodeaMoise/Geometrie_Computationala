using System;

namespace problema_2
{
    class prb2
    {
        //PROBLEMA 2
        static void Main(string[] args)
        {
            Console.WriteLine("Valori vector 1: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valori vector 2: ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            double i = y1 * z2 - z1 * y2;
            double j = -1 * (x1 * z2 - z1 * x2);
            double k = x1 * y2 - y1 * x2;
            if (i == 0 && j == 0 && k == 0)
            {
                Console.WriteLine("produs vectorial = 0");
                Console.WriteLine("COLINIARITATE");
            }
            else
            {
                if (i != 0)
                    Console.Write(i + "i");
                else if (i == 0)
                    Console.Write("");
                if (j > 0 && i != 0)
                    Console.Write("+" + j + "j");
                else if (j > 0 && i == 0)
                    Console.Write("" + j + "j");
                else if (j < 0)
                    Console.Write(j + "j");
                else if (j == 0)
                    Console.Write("");
                if (k > 0)
                    Console.Write("+" + k + "k");
                else if (k < 0)
                    Console.Write(k + "k");
                else if (k == 0)
                    Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("ARIA: " + Math.Sqrt(i * i + j * j + k * k));
                Console.WriteLine();
                Console.WriteLine("NU SUNT COLINIARE");
                Console.WriteLine();
            }
        }
    }
}
