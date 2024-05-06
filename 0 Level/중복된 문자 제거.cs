using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 중복된_문자_제거
{
    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            foreach (var c in my_string)
            {
                if (!answer.Contains(c))
                    answer += c;
            }

            return answer;
        }
    }
}
