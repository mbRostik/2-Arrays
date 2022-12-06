using System;

internal class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        for(int i = 0; i != a.Length; i++)
        {
            Console.WriteLine("Sumvol '" + a[i]+"' -> " + ((int)a[i]-97));
        }
    }
}
