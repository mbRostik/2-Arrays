using System;

internal class Ex2
{
    static void Main()
    {
        Console.WriteLine("Vvedite kol elementov: ");
        int k = int.Parse(Console.ReadLine());
        int[] a = new int[k];
        int[] b = new int[k];


        Console.WriteLine("Vvedite elementu: ");

        for (int i = 0; i != k; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vvedite kol rotations: ");

        int r = int.Parse(Console.ReadLine());

        for(int i=0; i!=r; i++)
        {
            int f = a[k-1];
            for (int y = k-1; y != 0; y--)
            {
                a[y] = a[y - 1];
            }
            a[0] = f;
            Console.WriteLine();
            for (int y = 0; y != k; y++)
            {
                Console.Write(a[y] + " ");
            }

            for(int y = 0; y != k; y++)
            {
                b[y] += a[y];
            }
        }

        Console.WriteLine("\n");

        for(int i = 0; i != k; i++)
        {
            Console.Write(b[i] + " ");
        }
    }
}
