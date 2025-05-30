using System;
using System.Numerics;
namespace Ejercicio_112
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            BigInteger c;
            string[] line = Console.ReadLine().Split(' ');
            a = int.Parse(line[0]);
            b = int.Parse(line[1]);
            if (a == b)
            {
                Console.WriteLine(0);
            }
            else
            {
                c = BigInteger.Pow((BigInteger)a, b) - BigInteger.Pow((BigInteger)b, a);
                Console.WriteLine(c);
            }
        }
    }
}