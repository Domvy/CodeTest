using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_정렬하기_2
{
    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            answer = string.Concat(my_string.ToLower().OrderBy(x => x));

            return answer;
        }
    }
}
