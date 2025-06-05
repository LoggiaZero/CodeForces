using System;

namespace Ejercicio_105
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] increments = new int[] { 0, 0, 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 9 };
            int n = int.Parse(Console.ReadLine());
            int resultado = (n / 15)*10 + increments[n % 15];
            Console.WriteLine(resultado);
            Console.ReadLine();
            
        }
    }
}
