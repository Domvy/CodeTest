using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 별_찍기___2
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if ((count - i) < j )
                    {
                        sb.Append("*");
                    }
                    else
                        sb.Append(" ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
