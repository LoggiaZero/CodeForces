using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_102
{
    class Program
    {
        static void Main(string[] args)
        {
            List<short> primes = new List<short>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            //short num = short.Parse(Console.ReadLine());
            for (short num = 1; num < 100; ++num)
            {
                short max = (short)Math.Sqrt(num);
                List<short> coprimes = primes.FindAll(item => item <= max && num % item == 0);
                int amount = num - 2;
                if (coprimes.Count == 0)
                {
                    Console.WriteLine($"{num}-{ Math.Max(0, amount)}");
                }
                else
                {
                    List<short> items = new List<short>();
                    int count = 0;
                    foreach(short coprime in coprimes)
                    {
                        count = num / coprime - 2;
                    }
                }
            }
        }
    }
}
