using System;

class prb3
{
    // 3 pct coliniare
    public static void Main()
    {

        int x1, x2, x3, y1, y2, y3;
        Console.WriteLine("Coordonatele punctului A: ");
        x1 = int.Parse(Console.ReadLine());
        y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Coordonatele punctului B: ");
        x2 = int.Parse(Console.ReadLine());
        y2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Coordonatele punctului C: ");
        x3 = int.Parse(Console.ReadLine());
        y3 = int.Parse(Console.ReadLine());

        coliniar(x1, y1, x2, y2, x3, y3);
    }

    static void coliniar(int x1, int y1, int x2,
                          int y2, int x3, int y3)
    {


        int a = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

        if (a == 0)
            Console.Write("Sunt coliniare");
        else
            Console.Write("Nu sunt coliniare");
    }


}
