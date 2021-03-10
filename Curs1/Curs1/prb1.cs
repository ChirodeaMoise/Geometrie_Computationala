using System;

class prb1
{


    public class Pair
    {
        public int first, second;

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
    }


    static void lineFromPoints(Pair P, Pair Q)
    {
        int a = Q.second - P.second;
        int b = P.first - Q.first;
        int c = a * (P.first) + b * (P.second);


        if (b < 0)
        {
            Console.WriteLine(" AB: " + -a + "x + " + -b + "y + " + c + " = 0");
            //"AB: " + a + "x + " + b + "y + " + c + " = 0");
        }
        else
        {
            Console.WriteLine("AB: " + -a + "x - " + b + "y " + c + " = 0");
            // " AB: " + a + "x - " + b + "y " + c + " = 0");
        }
    }

    // Driver code
    public static void Main(String[] args)
    {
        int a, b, c, d;
        Console.WriteLine("Coordonatele punctului A: ");
        a = int.Parse(Console.ReadLine());

        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Coordonatele punctulu B ");
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        Pair P = new Pair(a, b);
        Pair Q = new Pair(c, d);
        lineFromPoints(P, Q);
    }
}