using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace 최댓값만들기_2
{
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 0;

            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j) continue;
                    max = numbers[i] * numbers[j] > max ? numbers[i] * numbers[j] : max;
                }
            }

            return max;
        }
    }
}
