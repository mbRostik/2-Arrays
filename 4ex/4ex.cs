using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Vvedite element: ");
        int k = int.Parse(Console.ReadLine());

        int[] a = new int[k];
        int q = 1;
        for(int i = 0; i != k; i++)
        {
            a[i] = q;
            q++;
            Console.Write(a[i]+" \n");
        }
        a[0] = 0;
        int p = 2;

        int per=2;

        while (p!=11)
        {
            if ((per * p)-1 >= k)
            {
                p++;
                per = 2;
            }
            else
            {
                a[(per * p)-1] = 0;
                per++;
            }
        }
        Console.WriteLine();
        for (int i = 0; i != k; i++)
        {
            if (a[i] != 0)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
