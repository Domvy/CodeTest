using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 주사위의_개수
{
    public class Solution
    {
        public int solution(int[] box, int n)
        {
            int answer = 0;

            answer = box.Select(x => x / n).Aggregate((a, b) => a * b);

            return answer;
        }
    }
}
