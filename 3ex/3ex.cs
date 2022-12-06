using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Vvedite kol elementov (kratne 4): ");
        int k = int.Parse(Console.ReadLine());
        if (k % 4 == 0)
        {
            int[] a = new int[k];
            Console.WriteLine("Vvedite elementu: ");

            for (int i = 0; i != k; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int y = k / 4;
            int p = (k / 2);
            Console.WriteLine();
            Console.WriteLine();
            for(int i = p/2-1; i != -1; i--)
            {
                int t = a[i] + a[p - 1-i];

                Console.Write(t+ " \n");
            }
            int d = 1;
           for(int i = k - 1; i != (k / 2)+y-1; i--)
            { 

                int t = a[i] + a[i-p+d];
                Console.Write(t + " \n");
                d+=2;
            }

        }
        else
        {
            Console.WriteLine("Tam she bl napusano pro kratnist!");
        }
    }
}
