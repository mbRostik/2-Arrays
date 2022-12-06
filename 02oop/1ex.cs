using System;

internal class Ex1
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        int al = a.Length;
        int bl = b.Length;

        int k = 0;
        int k2=0;
        if ( al >= bl) 
        {
            int p1 = 1;
            int p2 = 0;

            for(int i = 0; i != bl; i++)
            {
                if (a[i] == b[i])
                {
                    k++;
                    if (b[i]==' ' && (b[i + 1] != ' ' && b[i + 1] == a[i+1]))
                    {
                        p1++;
                    }
                }
                else
                {
                    break;
                }
            }

            int ta = al;
            int tb = bl;

            while (tb > 0)
            {
                if (a[ta - 1] == b[tb - 1])
                {
                    k2++;
                    ta--;
                    tb--;
                    if (b[tb] == ' ' && (b[tb - 1] != ' '&& b[tb - 1] == a[ta-1]))
                    {
                        p2++;
                    }
                }
                else
                {
                    break;
                }
            }
            
           if(k!=0 || k2 != 0)
            {
                if (k >= k2)
                {
                    Console.Write("Kol slov: " + p1 + ". Slova: ");
                    for (int i = 0; i != k; i++)
                    {
                        Console.Write(b[i]);
                    }
                }
                else
                {
                    p2++;
                    Console.Write("Kol slov: " + p2 + ". Slova: ");
                    for (int i = bl - k2; i != bl; i++)
                    {
                        Console.Write(b[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nety slov");
            }
          }
        else
        {
            int p1 = 0;
            int p2 = 0;
            for (int i = 0; i != al; i++)
            {
                if (a[i] == b[i])
                {
                    k++;
                    if (a[i] == ' ' &&  (a[i+1] != ' ' && a[i + 1] == b[i+1]))
                    {
                        p1++;
                    }
                }
                else
                {
                    break;
                }
            }

            int ta = al;
            int tb = bl;

            while (ta > 0)
            {
                if (a[ta - 1] == b[tb - 1])
                {
                    k2++;
                    ta--;
                    tb--;
                    if (a[ta] == ' ' && (a[ta-1]!= ' ' && a[ta - 1] == a[tb-1]))
                    {
                        p2++;
                    }
                }
                else
                {
                    break;
                }
            }

            if(k!=0 || k2 != 0)
            {
                if (k >= k2)
                {
                    p1++;
                    Console.Write("Kol slov: " + p1 + ". Slova: ");
                    for (int i = 0; i != k; i++)
                    {
                        Console.Write(a[i]);
                    }
                }
                else
                {
                    Console.Write("Kol slov: " + p2 + ". Slova: ");
                    for (int i = al - k2; i != al; i++)
                    {
                        Console.Write(a[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nety slov");
            }
        }

    }
}
