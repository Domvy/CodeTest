using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유한소수_판별하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int a = 12;
            int b = 21;
            Console.WriteLine(solution.solution(a,b));
        }
    }
    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;

            int n = a > b ? a : b;
            while (!(a % n == 0 && b % n == 0))
            {
                n--;
            }
            b /= n;
            answer = 1;
            while (b >= 2)
            {
                if (b % 2 == 0)
                {
                    b /= 2;
                }
                else if (b % 5 == 0)
                {
                    b /= 5;
                }
                else
                {
                    answer = 2;
                    break;
                }                   
            }

            return answer;
        }
    }
}
