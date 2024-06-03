using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 최소_최대
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            StringBuilder sb = new StringBuilder();

            sb.Append($"{numbers.Min()}");
            sb.Append(" ");
            sb.Append($"{numbers.Max()}");
            Console.WriteLine(sb);
        }
    }
}
