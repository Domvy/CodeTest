using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 별_찍기___1
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
