using System;
using System.IO;

namespace Ejercicio_2110B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool balanced;
            StringReader brackets;
            int openbrackets=0;
            char bracket;
            for (int n = int.Parse(Console.ReadLine()); n > 0; --n)
            {
                balanced = false;
                brackets = new StringReader(Console.ReadLine());
                for (bracket = (char)brackets.Read(); !balanced; bracket = (char)brackets.Read())
                {
                    openbrackets += bracket == '(' ? 1 : -1;
                    balanced = openbrackets == 0;
                }
                
                Console.WriteLine(brackets.Read()==-1?"NO":"YES");
            }
        }
    }
}
