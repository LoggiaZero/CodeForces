using System;

namespace Ejercicio_4A
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            if (weight > 2 && (weight & 1) == 0)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}