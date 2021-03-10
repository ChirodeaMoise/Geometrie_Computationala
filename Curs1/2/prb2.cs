using System;

namespace Poblema_2
{
    class prb2
    {
        static void Main(string[] args)
        {

            int X_A, Y_A;
            int X_B, Y_B;
            Console.WriteLine("Coordonatele punctului A: ");
            X_A = int.Parse(Console.ReadLine());
            Y_A = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordonatele punctului B: ");
            X_B = int.Parse(Console.ReadLine());
            Y_B = int.Parse(Console.ReadLine());

            float distanta = (float)Math.Sqrt(((X_A - X_B) * (X_A - X_B)) + ((Y_A - Y_B) * (Y_A - Y_B)));
            Console.Write($"Distanta: {distanta} ");
        }
    }
}
