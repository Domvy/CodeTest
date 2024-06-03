using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 최댓값
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = new int[9];
            for (int i = 0; i < 9; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            sb.AppendLine($"{numbers.Max()}");
            sb.AppendLine($"{Array.IndexOf(numbers, numbers.Max()) + 1}");
            Console.WriteLine(sb);
        }
    }
}
