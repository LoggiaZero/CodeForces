using System;

namespace Ejercicio_102
{
    class Program
    {
        static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temporal = b;
                b = a % b;
                a = temporal;
            }
            return Math.Abs(a);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int coprimes = 1;
            for (int i = 2; i < num; coprimes += MCD(i++, num) == 1 ? 1 : 0) ;
            Console.WriteLine(coprimes);
        }
    }
}