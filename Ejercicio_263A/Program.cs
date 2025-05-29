using System;

namespace Ejercicio_263A
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int i, j;
            for(i=0; !(line=Console.ReadLine()).Contains("1");++i) ;
            string[] data = line.Split(' ');
            for (j=0; data[j] != "1"; ++j) ;
            Console.WriteLine(Math.Abs(2 - i) + Math.Abs(2 - j));
        }
    }
}
