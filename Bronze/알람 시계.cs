using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 알람_시계
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int H = numbers[0];
            int M = numbers[1];
            M -= 45;
            if (M >= 0)
            {
                Console.WriteLine($"{H} {M}");
            }
            else
            {
                if (0 < H)
                {
                    Console.WriteLine($"{H - 1} {60 + M}");
                }
                else
                {
                    Console.WriteLine($"23 {60 + M}");
                }
            }
        }
    }
}
