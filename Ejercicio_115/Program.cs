using System;

namespace Ejercicio_115
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daymonth = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);
            DateTime start = new DateTime(2000, 12, 31);
            start = start.AddDays(daymonth[0]).AddMonths(daymonth[1]-1);
            if(start.Year == 2001 && start.Day == daymonth[0] && start.Month == daymonth[1])
                Console.WriteLine(start.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)start.DayOfWeek);
            else
                Console.WriteLine("Impossible");
            Console.ReadLine();
        }
    }
}
