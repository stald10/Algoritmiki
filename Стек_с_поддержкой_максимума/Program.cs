namespace SMax
{
    public class StackMax
    {
        public static Stack<int> _stackElem = new();
        public static Stack<int> _stackMax = new();

        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < N; ++i) 
            {
                string[] input = Console.ReadLine()!.Split();

                string operation = input[0];
                int elem = 0;

                if (operation.Length != 3) 
                {
                    elem = int.Parse(input[1]);
                } 

                switch (operation) 
                {
                    case "push" :
                        
                        _stackElem.Push(elem);
                        if (_stackMax.Count == 0) _stackMax.Push(elem);
                        else 
                        {
                            _stackMax.Push(Math.Max(elem, _stackMax.Peek()));
                        }
                        break;
                    case "pop":
                        _stackElem.Pop();
                        _stackMax.Pop();
                        break;
                    case "max":
                        Console.WriteLine(_stackMax.Peek());
                        break;
                }

                
            }

        }
    }
}

