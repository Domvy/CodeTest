using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 순서쌍의_개수
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
           
            answer = Enumerable.Range(1,n).Where(x => n % x == 0).Count();

            return answer;
        }
    }
}
