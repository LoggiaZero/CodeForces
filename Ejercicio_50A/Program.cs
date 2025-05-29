using System;

namespace Ejercicio_50A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int m = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            Console.WriteLine((m * n) / 2);
        }
    }
}
