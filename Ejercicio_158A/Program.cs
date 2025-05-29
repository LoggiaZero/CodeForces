using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_158A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int k = int.Parse(data[1]);
            List<int> scores = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse).ToList();
            int minscore = scores[k-1];
            Console.WriteLine(scores.Count(item => item >= minscore && item > 0));
        }
    }
}
