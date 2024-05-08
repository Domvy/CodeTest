using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n의_배수_고르기
{
    public class Solution
    {
        public int[] solution(int n, int[] numlist)
        {
            int[] answer = new int[] { };

            answer = numlist.Where(x => x % n == 0).ToArray();

            return answer;
        }
    }
}
