using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_123
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            List<int> fib = new List<int>() { 1, 1 };
            for (int i = 1; ++i < k; fib.Add(fib[i - 1] + fib[i - 2]));
            Console.WriteLine(k == 1 ? 1 : fib.Sum());
        }
    }
}