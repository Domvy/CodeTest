using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 한_번만_등장한_문자
{
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
                        
            foreach (char c in s) 
            {
                if(s.IndexOf(c) == s.LastIndexOf(c))
                    answer += c;
            }            

            return string.Concat(answer.OrderBy(x => x));
        }
    }
}
