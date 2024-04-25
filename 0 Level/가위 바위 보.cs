using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가위_바위_보
{
    public class Solution
    {
        public string solution(string rsp)
        {
            string answer = "";

            foreach (var c in rsp)
            {
                answer += c == '0' ? '5' : c == '2' ? '0' : '2';
            }             

            return answer;
        }
    }
}
