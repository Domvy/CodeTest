using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 공_던지기
{
    public class Solution
    {
        public int solution(int[] numbers, int k)
        {
            int answer = 0;

            int n = 0;
            for (int i = 0; i < k - 1; i++)
            {
                if (n + 2 > numbers.Length)
                {
                    n -= numbers.Length - 2;
                }
                else
                    n += 2;
            }
            answer = numbers[n];

            return answer;
        }
    }
}
