using System;

namespace Ejercicio_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            Console.WriteLine($"{a+b}");
        }
    }
}