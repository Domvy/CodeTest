using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _369게임
{
    public class Solution
    {
        public int solution(int order)
        {
            int answer = 0;

            int n = 0;
            while (order > 0)
            {
                n = order % 10;
                answer += n % 3 == 0 && n != 0 ? 1 : 0;
                order /= 10;
            }

            return answer;
        }
    }
}
