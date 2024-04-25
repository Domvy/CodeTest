using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특정_문자_제거하기
{
    public class Solution
    {
        public string solution(string my_string, string letter)
        {
            string answer = "";

            foreach (char c in my_string)
            {
                if (!c.Equals(char.Parse(letter)))
                {
                    answer += c;
                }                
            }            
            return answer;
        }
    }
}
