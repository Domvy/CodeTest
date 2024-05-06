using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_정렬하기
{
    public class Solution
    {
        public int[] solution(string my_string)
        {
            int[] answer = new int[] { };

            answer = my_string.Where(x => 48 <= (int)x && (int)x <= 57).
                Select(x => int.Parse(x.ToString())).OrderBy(x => x).ToArray();

            return answer;
        }
    }
}
