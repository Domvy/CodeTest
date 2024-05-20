using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 삼각형의_완성조건_2
{
    public class Solution
    {
        public int solution(int[] sides)
        {
            int answer = 0;

            answer += Enumerable.Range(1, 2000).Where(x => x <= sides.Max() && sides.Max() < x + sides.Min()).Count();
            answer += Enumerable.Range(1, 2000).Where(x => sides.Max() < x && x < Enumerable.Sum(sides)).Count();


            return answer;
        }
    }
}
