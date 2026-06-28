using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(countZeros(int.Parse(Console.ReadLine()!),0));
    }

    public static int countZeros(int n, int x) 
    {
        if (n % 10 == 0 && n != 0)
        {
            n /= 10;
            x += countZeros(n,x) + 1;

        }
        else if (n != 0)
        {
            n /= 10;
            x += countZeros(n,x);
        }
        return x;
    }
}