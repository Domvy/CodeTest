using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 오븐_시계
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int H = numbers[0]; int M = numbers[1];
            M += n;
            if (M < 60)
            {
                Console.WriteLine($"{H} {M}");
            }
            else
            {
                H += M / 60;
                M %= 60;

                if (H >= 24)
                {
                    Console.WriteLine($"{H - 24} {M}");
                }
                else
                    Console.WriteLine($"{H} {M}");
            }
        }
    }
}
