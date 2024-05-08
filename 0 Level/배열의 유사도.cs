using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 배열의_유사도
{
    public class Solution
    {
        public int solution(string[] s1, string[] s2)
        {
            int answer = 0;

            answer = s1.Where(x => s2.Contains(x)).Count();

            return answer;
        }
    }
}
