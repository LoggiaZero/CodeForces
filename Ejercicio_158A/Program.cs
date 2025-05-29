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
            List<int> score = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse).ToList();
            Console.WriteLine(score[0]>k? score.Count(item => item > k):score.Count(item => item == k));
        }
    }
}
