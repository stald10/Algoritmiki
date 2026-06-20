 using System;
 using System.Collections.Generic;
 using System.IO;
 using System.Linq;
 using System.Net.Http;
 using System.Threading;
 using System.Threading.Tasks;
namespace TreeSystem 
{
    public static class Tree
    {
        public static List<List<int>>? adjancylist = [];

        public static List<bool>? visit = [];

        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            var arr = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList();

            adjancylist = adjancyList(arr);
            for (int i = 0; i < N; ++i) visit!.Add(false);

            Console.WriteLine(Depth(arr.FindIndex(x => x == -1)));
        }

        public static List<List<int>> adjancyList(List<int> adj)
        {
            List<int> index = Enumerable.Range(0, adj.Count).ToList();

            List<List<int>> newAdj = [];
            for (int i = 0; i < adj.Count; ++i) newAdj.Add([]);

            foreach ((int ind, int value) in index.Zip(adj))
            {
                if (value != -1) newAdj[value].Add(ind);
            }

            return newAdj;

        }

        public static int Depth(int index)
        {
            visit![index] = true;
            int height = 1;
            foreach (var elem in adjancylist![index])
            {
                if (!visit![elem]) height = Math.Max(height, 1 + Depth(elem));
            }
            return height;

        }
    }
}
