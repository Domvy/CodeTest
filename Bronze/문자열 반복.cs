using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 문자열_반복
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                string[] strings = Console.ReadLine().Split(' ').ToArray();
                int repeat = int.Parse(strings[0]);
                string main = strings[1];
                for (int j = 0; j < main.Length; j++)
                {
                    sb.Append(string.Concat(Enumerable.Repeat(main[j], repeat)));
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
