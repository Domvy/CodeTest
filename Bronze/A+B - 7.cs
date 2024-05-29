using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class A_B___7
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (i != 0) sb.AppendLine();
                sb.Append($"Case #{i + 1}: ");
                sb.Append(Console.ReadLine().Split(' ').Select(int.Parse).Aggregate((x, y) => x + y));
            }
            Console.WriteLine(sb);
        }
    }
}
