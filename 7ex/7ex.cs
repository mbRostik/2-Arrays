using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Razmer: ");
        int k = int.Parse(Console.ReadLine());

        int[] a = new int[k];

        int start = 0;
        int dv = 1;
        int tl = 0;
        Console.WriteLine("Vvedit elemntu: ");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i]+1 == a[i + 1])
            {
                dv++;
            }
            else
            {
                dv = 1;
            }
            if (dv > start)
            {
                start = dv;
                tl = a[i];
            }
        }
        Console.WriteLine("Resultat: ");
        for (int i = 0; i <= start-1; i++)
        {
            Console.WriteLine(tl-i+1);
        }

    }
}
