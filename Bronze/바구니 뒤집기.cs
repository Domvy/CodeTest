using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 바구니_뒤집기
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] baskets = Enumerable.Range(1, firstLine[0]).ToArray();
            int count = firstLine[1];

            for (int i = 0; i < count; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Select(x => x - 1).ToArray();
                Array.Reverse(baskets, numbers[0], numbers[1] - numbers[0] + 1);                
            }
            foreach (int n in baskets) 
            {
                sb.Append(n);
                sb.Append(' ');
            }
            Console.WriteLine(sb);
        }
    }
}
