using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 합성수_찾기
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 1; j <= n - i; j++)
                {
                    count += (n - i) % j == 0 ? 1 : 0;
                }
                answer += 3 <= count ? 1 : 0;
            }

            return answer;
        }
    }
}
