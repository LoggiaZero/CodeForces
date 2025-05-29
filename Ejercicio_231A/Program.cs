using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio_231A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values;
            int votes;
            int implementations = 0;
            for(int n = int.Parse(Console.ReadLine());n>0;--n)
            {
                values = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse).ToList();
                votes = values.Sum();
                implementations += votes >= 2 ? 1 : 0;
            }
            Console.Write(implementations);
        }
    }
}
