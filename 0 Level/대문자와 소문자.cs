using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 대문자와_소문자
{
    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            for (int i = 0; i < my_string.Length; i++)
            {
                answer += char.IsLower(my_string[i]) ? char.ToUpper(my_string[i]) : char.ToLower(my_string[i]);
            }

            return answer;
        }
    }
}
