using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 공_넣기
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int baskets = firstLine[0];
            int count = firstLine[1];
            int[] result = new int[baskets];

            for (int i = 0; i < count; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = numbers[0] - 1; j < numbers[1]; j++)
                {
                    result[j] = numbers[2];
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (i != 0) sb.Append(" ");
                sb.Append($"{result[i]}");
            }
            Console.WriteLine(sb);
        }
    }
}
