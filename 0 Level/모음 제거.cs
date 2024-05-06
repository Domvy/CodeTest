using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 모음_제거
{
    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            char[] chars = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < my_string.Length; i++)
            {
                if (!chars.Contains(my_string[i]))
                {
                    answer += my_string[i];
                }                
            }

            return answer;
        }
    }
}
