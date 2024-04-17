using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 주사위_게임
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int a = 3;
            int b = 5;
            Console.WriteLine(solution.solution(a, b));
        }
    }    
    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;

            int c = a + b;
            if (c % 2 == 1)
            {
                return 2 * (a + b);
            }
            else if (c % 2 == 0 && a % 2 == 1)
            {
                return (a * a) + (b * b);
            }
            else
            {
                return Math.Abs(a - b);
            }
        }
    }
}
