using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Razmer: ");
        ushort k = ushort.Parse(Console.ReadLine());

        ushort[] a = new ushort[k];

        Console.WriteLine("Vvedit elemntu: ");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = ushort.Parse(Console.ReadLine());
        }

        int f = 0;
        int s = 0;
        int f2 = 0;
        int s2 = 0;

        for(ushort i = 0; i != k; i++)
        {
            f = 0;
            f2 = a[i];
            for(int y = i; y != k; y++)
            {
                if (a[i] == a[y])
                {
                    f2 = a[i];
                    f++;
                }
            }
            if (f > s)
            {
                s2 = f2;
                s = f;
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("4islo - "+s2+" - zystrilos "+s+" razu");
    }
}
