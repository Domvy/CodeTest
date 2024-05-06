using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 삼각형의_완성조건
{
    public class Solution
    {
        public int solution(int[] sides)
        {
            int answer = 0;

            answer = (sides.Max() * 2) < sides.Sum() ? 1 : 2;

            return answer;
        }
    }
}
