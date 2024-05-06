using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 팩토리얼
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 0; Factorial(i) <= n; i++)
            {
                answer = i;
            }

            return answer;
        }
        public int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
                return num * Factorial(num - 1);
        }
    }
}
