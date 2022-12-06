using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Razmer: ");
        ushort k = ushort.Parse(Console.ReadLine());

        ushort[] a = new ushort[k];
        ushort p = 0;
        Console.WriteLine("Razniza: ");
        ushort d = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Vvedit elemntu: ");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = ushort.Parse(Console.ReadLine());
        }
        for(int i = 0; i != k; i++)
        {
            for(int y = i; y != k; y++)
            {
                if (a[i] + d == a[y] || a[i] == a[y] + d)
                {
                    p++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine(p);
    }
}
