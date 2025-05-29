using System;

namespace Ejercicio_2114A
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int minyear;
            int a, b;
            for(int tc = int.Parse(Console.ReadLine());tc>0;--tc)
            {
                year = int.Parse(Console.ReadLine());
                minyear = (int)Math.Sqrt(year);
                if(minyear*minyear == year)
                {
                    if((minyear & 1) == 0)
                    {
                        a = minyear / 2;
                        b = a;
                    }
                    else
                    {
                        a = minyear / 2;
                        b = a + 1;
                    }
                    Console.WriteLine($"{a} {b}");
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
