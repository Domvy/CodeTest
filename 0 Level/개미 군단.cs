using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 개미_군단
{
    public class Solution
    {
        public int solution(int hp)
        {
            int answer = 0;

            int a = 5;
            int b = 3;
            int c = 1;

            while (hp != 0)
            {
                hp -= hp >= a ? a : hp >= b ? b : c;
                answer++;
            }

            return answer;
        }
    }
}
