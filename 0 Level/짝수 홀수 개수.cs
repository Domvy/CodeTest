using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 짝수_홀수_개수
{
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[] { };

            answer = new int[2];
            answer[0] = num_list.Where(x => x % 2 == 0).Count();
            answer[1] = num_list.Where(x => x % 2 == 1).Count();

            return answer;
        }
    }
}
