using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class A_B___5
    {
        static void Main(string[] args)
        {
            int result = 0;
            StringBuilder sb = new StringBuilder();
            while (true) 
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();                
                result = numbers[0] + numbers[1];
                if (result != 0)
                {
                    sb.Append($"{result}");
                    sb.AppendLine();
                }
                else
                {
                    Console.WriteLine(sb);
                    break;
                }
            }       
        }
    }
}
