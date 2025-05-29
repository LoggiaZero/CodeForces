using System;

namespace Ejercicio_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = Array.ConvertAll<string, double>(Console.ReadLine().Split(' '), double.Parse);
            Console.WriteLine((long)((Math.Ceiling(data[0] / data[2]) * Math.Ceiling(data[1]/data[2]))));
        }
    }
}