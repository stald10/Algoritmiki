internal class Program
{
    private static void Main(string[] args)
    {
        var matrixSize = Console.ReadLine()!.Split(" ");

        int N = int.Parse(matrixSize[0]);
        int M = int.Parse(matrixSize[1]);

        List<List<int>> matrix = new();
        List<List<int>> matrixTranpose = new();

        for (int i = 0; i < M; ++i) 
        {
            matrixTranpose.Add(Enumerable.Repeat(0, N).ToList());
        }

        for (int i = 0; i < N; ++i) 
        {
            matrix.Add(Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList());
        }

        for (int i = 0; i < M; ++i)
        {
            for (int j = 0; j < N; ++j) 
            {
                matrixTranpose[i][j] = matrix[N- j - 1][i];
            }
        }

        Console.WriteLine($"{M} {N}");
        foreach (var elem in matrixTranpose) 
        {
            Console.WriteLine(string.Join(" ", elem));
        }

    }
}