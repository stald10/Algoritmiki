using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace BracketsSystem

{
    public static class Brackets
    {
        private static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int count_brack = check_brackets(str);
            if (count_brack == 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine(count_brack);
            }
        }


        public static int check_brackets(string str)
        {
            Stack<(char, int)> brackets = new();

            for (int i = 0; i < str.Length; ++i)
            {
                char c = str[i];
                if (c == '(' || c == '[' || c == '{') brackets.Push((c, i + 1));
                else if (c == ')' || c == ']' || c == '}')
                {
                    (char, int) head;
                    var res = brackets.TryPop(out head);
                    if (!res) return i+1;
                    if (
                        (head.Item1 == '[' && c != ']') ||
                        (head.Item1 == '(' && c != ')') ||
                        (head.Item1 == '{' && c != '}')
                        ) return i+1;
                }
            }

            foreach (var elem in brackets)
            {
                var item = brackets.Pop();
                return item.Item2;
 
            }
            return 0;

        }
    }

}
