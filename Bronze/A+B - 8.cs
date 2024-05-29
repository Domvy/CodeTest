using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class A_B___8
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i != 0) sb.AppendLine();
                sb.Append($"Case #{i + 1}: ");
                sb.Append($"{numbers[0]} + {numbers[1]} = ");
                sb.Append($"{numbers[0] + numbers[1]}");
            }
            Console.WriteLine(sb);
        }
    }
}
