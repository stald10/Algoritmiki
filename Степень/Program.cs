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
    private static void Main(string[] args)
    {

        var input = Console.ReadLine()!.Split(" ").ToList();

        Console.WriteLine($"{calculatePower(float.Parse(input[0]), float.Parse(input[1])):F2}".Replace(",","."));
    }

    static float calculatePower(float Base, float exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else 
        {
            exponent--;
            return Base * calculatePower(Base, exponent);
        }
    }
}