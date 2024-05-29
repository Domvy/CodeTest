using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class A_B___4
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int result = 0;
            string read = "";
            while((read = Console.ReadLine()) != null)
            {
                int[] numbers = read.Split(' ').Select(int.Parse).ToArray();
                sb.AppendLine($"{numbers[0] + numbers[1]}");
            }
            Console.WriteLine(sb);
        }
    }
}
