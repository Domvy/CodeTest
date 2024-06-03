using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class X보다_작은_수
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = first[0];
            int max = first[1];
            string answer = "";

            for (int i = 0; i < count; i++)
            {
                if (second[i] < max)
                {
                    if (answer.Length != 0) answer += " ";
                    answer += $"{second[i]}";
                }                
            }
            Console.WriteLine(answer);
        }
    }
}
