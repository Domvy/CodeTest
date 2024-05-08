using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 세균_증식
{
    public class Solution
    {
        public int solution(int n, int t)
        {
            int answer = 0;

            answer = n * Convert.ToInt32(Math.Pow(2, t));

            return answer;
        }
    }
}
