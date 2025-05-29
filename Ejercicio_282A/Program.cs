using System;

namespace Ejercicio_282A
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for(int n = int.Parse(Console.ReadLine());n>0;--n)
            {
                //x += Console.ReadLine().Contains("+") ? 1 : -1;
                 x += Console.ReadLine()[1]=='+'?1:-1;
            }
            Console.WriteLine(x);
        }
    }
}