using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가장_큰_수_찾기
{
    public class Solution
    {
        public int[] solution(int[] array)
        {
            int[] answer = new int[] { };

            answer = new int[] {array.Max(), Array.IndexOf(array, array.Max())};

            return answer;
        }
    }
}
