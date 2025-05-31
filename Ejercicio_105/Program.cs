using System;

namespace Ejercicio_105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 0, i;
            for (i = 1; i != n; ++i)
            {
                a = (a + i) % 3;
                b += a == 0 ? 1 : 0;
            }
            a = (a + i) % 3;
            b += a == 0 ? 1 : 0;
            Console.WriteLine(b);
        }
    }
}
