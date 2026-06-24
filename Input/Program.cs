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


var input = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList();

int N = input[0];
int M = input[1];


string res;
if (N > M)
{
    res = string.Concat(Enumerable.Repeat("BG", M));
    Regex regex = new("GB");
    res = regex.Replace(res, "GBB", N - M);
}
else
{
    res = string.Concat(Enumerable.Repeat("GB", N));
    Regex regex = new("BG");
    res = regex.Replace(res, "BGG", M - N);
}

if (res.Length == N + M) Console.WriteLine(res);
else if ((Math.Abs(res.Length - (N + M))) == 1)
{
    if (N > M) res += "B";
    else res += "G";
    Console.WriteLine(res);
}
else Console.WriteLine("NO SOLUTION");




