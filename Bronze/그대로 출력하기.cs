using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 그대로_출력하기
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;
                else
                    sb.AppendLine(input);
            }
            Console.WriteLine(sb);
        }
    }
}
