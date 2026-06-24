using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks.Dataflow;
using System.Net;
using System.ComponentModel.Design;
namespace SlidingWindow 
{
#nullable enable
    public class UltimateStack 
    {
        public  Stack<int>? _nextStack;
        public  Stack<int>? _prevStack;

        public List<int> collect = new();
        public UltimateStack(int M) 
        {
            _nextStack = new Stack<int>(M);
            _prevStack = new Stack<int>(M);
        }

        public void PushBack(int i) 
        {
            _prevStack!.Push(i);
        }

        public int PopFront() 
        {
            if (_nextStack!.Count == 0)
            {
                while (_prevStack!.Count != 0)
                {
                    _nextStack!.Push(_prevStack!.Peek());
                    _prevStack.Pop();
                }
            }
            return _nextStack!.Pop();
        }

        public void MaxStack(UltimateStack stack) 
        {
            foreach (var i in stack._nextStack!.Reverse()) 
            {
                if (_nextStack!.Count == 0) _nextStack.Push(i);
                else
                {
                    _nextStack.Push(Math.Max(i, _nextStack.Peek()));
                }
            }
            foreach (var i in stack._prevStack!.Reverse()) 
            {
                if (_prevStack!.Count == 0) _prevStack.Push(i);
                else
                {
                    _prevStack.Push(Math.Max(i, _prevStack.Peek()));
                }
            }


            if (_prevStack!.Count == 0) collect.Add(_nextStack!.Peek());
            else if (_nextStack!.Count == 0) collect.Add(_prevStack.Peek());
            else collect.Add(Math.Max(_nextStack.Peek(), _prevStack.Peek()));


            _prevStack.Clear();
            _nextStack.Clear();
        }

        

    }


    public class MaxWindow
    {
        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            List<int> elem = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList();
            int M = int.Parse(Console.ReadLine()!);

            UltimateStack _Stack = new(M);
            UltimateStack _MaxStack = new(M);

            for (int i = 0; i < M; ++i) 
            {
                _Stack.PushBack(elem[i]);   
            }
            _MaxStack.MaxStack(_Stack);

            for (int i = M; i < N; ++i) 
            {
                _Stack.PopFront();
                _Stack.PushBack(elem[i]);
                _MaxStack.MaxStack(_Stack);
            }

            Console.WriteLine(string.Join(" ", _MaxStack.collect));


 

        }
    }
}

