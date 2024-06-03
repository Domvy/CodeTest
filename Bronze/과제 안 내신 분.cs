using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 과제_안_내신_분
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int count = 28;
            int[] result = new int[] { };
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            result = Enumerable.Range(1,30).Where(x => !numbers.Contains(x)).ToArray();
            sb.AppendLine($"{result[0]}");
            sb.AppendLine($"{result[1]}");
            Console.WriteLine(sb);
        }
    }
}
