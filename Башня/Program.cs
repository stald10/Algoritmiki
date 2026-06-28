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
        HanoiTower(int.Parse(Console.ReadLine()!), 1, 3);
    }


    public static void HanoiTower(int n, int first, int last) 
    {
        if (n == 1) { Console.WriteLine($"Переместите диск с {first} на {last}"); return; }
        int middle = 6 - first - last;
        HanoiTower(n - 1, first, middle);
        Console.WriteLine($"Переместите диск с {first} на {last}");
        HanoiTower(n - 1, middle, last);
    }

}

