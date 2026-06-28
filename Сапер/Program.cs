using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
internal class Program
{

    public struct BombPoint 
    {
        public int x;
        public int y;
    }

    private static void Main(string[] args)
    {
        var firstInput = Console.ReadLine()!.Split(" ").ToList();

        int N = int.Parse(firstInput[0]);
        int M = int.Parse(firstInput[1]);

        int W = int.Parse(Console.ReadLine()!);

        List<BombPoint> points = new();

        List<List<int>> table = new();
        List<List<char>> tableResult = new();

        for (int i = 0; i < N; ++i) 
        {
            table.Add(Enumerable.Repeat(0, M).ToList());
            tableResult.Add(Enumerable.Repeat('0', M).ToList());
 
        }

        for (int i = 0; i < W; ++i) 
        {
            var point = Console.ReadLine()!.Split(" ");
            points.Add(new BombPoint { x = int.Parse(point[1]) - 1, y = int.Parse(point[0]) - 1 });
        }

        
        foreach (var point in points) 
        {
            int i = point.x, j = point.y;
            if (i + 1 < M)                table[j][i + 1] += 1;
            if (0 <= i - 1)               table[j][i - 1] += 1;
            if (0 <= j - 1)               table[j - 1][i] += 1;
            if (j + 1 < N)                table[j + 1][i] += 1;
            if (i + 1 < M && j + 1 < N)   table[j + 1][i + 1] += 1; 
            if (i + 1 < M && 0 <= j - 1)  table[j - 1][i + 1] += 1;
            if (0 <= i - 1 && j + 1 < N)  table[j + 1][i - 1] += 1;
            if (0 <= i - 1 && 0 <= j - 1) table[j - 1][i - 1] += 1;
        }

        tableResult = table.Select(x => x.Select(y => (char)(y+'0')).ToList()).ToList();


        foreach (var point in points)
        {
            int i = point.x, j = point.y;
            tableResult[j][i] = '*';
        }

        foreach (var elem in tableResult) 
        {
            Console.WriteLine(string.Join(" ", elem));
        }
    }
}