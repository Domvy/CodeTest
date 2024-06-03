using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 개수_세기
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int answer = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] == answer)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
