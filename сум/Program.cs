using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine()!);

        List<List<int>> matrix = new();

        for (int i = 0; i < N; i++) 
        {
            matrix.Add(Console.ReadLine()!.Split(" ").Select(x=>int.Parse(x)).ToList());
        }

        for (int i = 0; i < N; ++i) 
        {
            for (int j = 0; j < N; ++j) 
            {
                if (i == j) continue;
                if (matrix[i][j] != matrix[j][i]) 
                {
                    Console.WriteLine("no");
                    return;
                }
            }
        }
        Console.WriteLine("yes");


    }
}