using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 주사위_세개
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];

            if (a == b && a == c)
            {
                Console.WriteLine(10000 + a * 1000);
            }
            else if (a == b || a == c || b == c)
            {
                if (b == c)
                {
                    Console.WriteLine(1000 + b * 100);
                }
                else
                    Console.WriteLine(1000 + a * 100);
            }
            else
                Console.WriteLine(numbers.Max() * 100);
        }
    }
}
