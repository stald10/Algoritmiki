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
        isPalindrome(Console.ReadLine()!);
    }

    public static void isPalindrome(string s) 
    {
        int len = s.Length - 1;
        if (len == 0 || len == -1) 
        {
            Console.WriteLine("True");
            return;
        }
        else if (s[0] == s[s.Length-1]) 
        {
            isPalindrome(s[1..len]);
        }
        else 
        {
            Console.WriteLine("False");
            return;
        }
    }

}