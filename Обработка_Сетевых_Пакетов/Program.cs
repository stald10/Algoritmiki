
namespace Processor 
{
    public class Proc
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split(" ");

            int N = int.Parse(input[0]);
            int size = int.Parse(input[1]);

            Queue<int> buffer = new(N);

            int cpu = 0;

            for (int i = 0; i < size; ++i) 
            {
                var data = Console.ReadLine()!.Split(" ");

                int arrival = int.Parse(data[0]);
                int duration = int.Parse(data[1]);

                while (!(buffer.Count == 0) && buffer.Peek() <= arrival) 
                {
                    buffer.Dequeue();
                }

                if (cpu < arrival)
                {
                    Console.WriteLine(arrival);
                    cpu = arrival + duration;
                    buffer.Enqueue(cpu);
                }
                else if (buffer.Count < N)
                {
                    Console.WriteLine(cpu);
                    cpu += duration;
                    buffer.Enqueue(cpu);
                }
                else 
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
