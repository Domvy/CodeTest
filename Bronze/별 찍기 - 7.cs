using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 별_찍기___7
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(Console.ReadLine());
            int line = count * 2 - 1;
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j <= line; j++)
                {
                    if (count - i <= j && j <= count + i)
                        sb.Append("*");
                    else if(j < count - i)
                        sb.Append(" ");
                }
                sb.AppendLine();
            }
            for (int i = count - 2; 0 <= i; i--)
            {
                for (int j = 1; j <= line; j++)
                {
                    if (count - i <= j && j <= count + i)
                        sb.Append("*");
                    else if(j < count - i)
                        sb.Append(" ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);

        }
    }
}
