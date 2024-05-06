using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 숨어있는_숫자의_덧셈_1
{
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;

            answer = my_string.Where(x => 48 <= (int)x && (int)x <= 57).Select(x => int.Parse(x.ToString())).Sum();
            
            return answer;
        }
    }
}
