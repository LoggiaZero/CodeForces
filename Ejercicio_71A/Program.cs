using System;
using System.Text;

namespace Ejercicio_71A
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            string word;
            int count;
            for(int n = int.Parse(Console.ReadLine());n>0;--n)
            {
                word = Console.ReadLine();
                count = word.Length;
                if (count > 10)
                    answer.AppendLine($"{word[0]}{count - 2}{word[count - 1]}");
                else
                    answer.AppendLine(word);
            }
            Console.Write(answer);
        }
    }
}
