using System;

namespace Ejercicio_112A
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(string.Compare(a.ToLower(), b.ToLower()));
        }
    }
}
