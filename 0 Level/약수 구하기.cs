using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 약수_구하기
{
    public class Solution
    {
        public int[] solution(int n)
        {
            int[] answer = new int[] { };

            answer = Enumerable.Range(1,n).Where(x => n % x == 0).OrderBy(x => x).ToArray();

            return answer;
        }
    }
}
