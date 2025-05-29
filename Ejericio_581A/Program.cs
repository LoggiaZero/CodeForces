using System;

namespace Ejericio_581A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] socks = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);
            int firstwear = Math.Min(socks[0], socks[1]);
            socks[0] -= firstwear;
            socks[1] -= firstwear;
            Console.Write($"{firstwear} {socks[0]/2 + socks[1]/2}");
        }
    }
}
