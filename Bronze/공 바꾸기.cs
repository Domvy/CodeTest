using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 공_바꾸기
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] baskets = Enumerable.Range(1, firstLine[0]).ToArray();
            int count = firstLine[1];

            int[] change = new int[] { };
            for (int i = 0; i < count; i++)
            {
                change = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int temp = baskets[change[0] - 1];
                baskets[change[0] - 1] = baskets[change[1] - 1];
                baskets[change[1] - 1] = temp;
            }
            for (int i = 0; i < baskets.Length; i++)
            {
                if (i != 0) sb.Append(" ");
                sb.Append($"{baskets[i]}");
                if (i == baskets.Length - 1) Console.WriteLine(sb);
            }
        }
    }
}
