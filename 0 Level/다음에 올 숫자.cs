using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다음에_올_숫자
{
    public class Solution
    {
        public int solution(int[] common)
        {
            int answer = 0;

            int a = common[0];
            int b = common[1];
            int c = common[2];

            if (!(a + c == 2 * b))
            {
                answer = common[common.Length - 1] * (b / a);
            }
            else
            {
                answer = common[common.Length - 1] + (b - a);
            }

            return answer;
        }
    }
}
