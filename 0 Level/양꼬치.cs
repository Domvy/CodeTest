using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 양꼬치
{
    public class Solution
    {
        public int solution(int n, int k)
        {
            int answer = 0;

            k -= n / 10 > 0 ? n / 10 : 0;
            answer = n * 12000 + k * 2000;            

            return answer;
        }
    }
}
