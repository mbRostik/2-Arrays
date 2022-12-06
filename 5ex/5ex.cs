using System;

internal class Program
{
    static void vudal(ref string a)
    {
        for(int i = 0; i != a.Length; i++)
        {
            if (a[i]==' ')
            {
                a = a.Remove(i, 1);
                i--;
            }
        }
    }
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        Console.WriteLine();
        int kol=a.Length;
        vudal(ref a);
        vudal(ref b);
        if (kol > b.Length)
        {
            kol = b.Length;
        }
        int bk = 0;
        for (int i = 0; i != kol; i++)
        {
            if (a[i] < b[i])
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                break;
            }
            else if (a[i] == b[i])
            {
                bk++;
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                break;
            }
        }
        if (bk == kol)
        {
            if (kol == a.Length)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }
    }
}
