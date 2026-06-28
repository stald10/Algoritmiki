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


//N программистов и MM программисток пошли в кинотеатр и купили билеты на подряд идущие места в одном ряду. Напишите программу, которая выдаст, как нужно сесть программистам и программисткам, чтобы рядом с каждым программистом сидела хотя бы одна программистка, а рядом с каждой программисткой --- хотя бы один программист.

//Формат ввода

//Вводятся два числа - NN и MM (оба числа натуральные, не превосходящие 100100).

//Формат вывода

//Выведите какую-нибудь строку, в которой будет ровно NN символов B (обозначающих программистов) и MM символов G (обозначающих программисток), удовлетворяющую условию задачи. Пробелы между символами или после всех символов выводить не нужно. Если рассадить программистов и программисток согласно условию задачи невозможно, выведите строку NO SOLUTION.

//Примечание

//Обратите внимание, что решение с полным перебором вариантов рассадки может не пройти по времени.


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




