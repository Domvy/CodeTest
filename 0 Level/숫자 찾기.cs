using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 숫자_찾기
{
    public class Solution
    {
        public int solution(int num, int k)
        {
            int answer = 0;

            int f = 0;
            int l = int.MinValue;
            while (num > 0)
            {
                if (num % 10 == k)
                    l = f;
                f++;
                num /= 10;
            }
            answer = l == int.MinValue ? -1 : f - l;

            return answer;
        }
    }
}
