using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이진수_더하기
{
    public class Solution
    {
        public string solution(string bin1, string bin2)
        {
            string answer = "";

            int n = 0;
            n += Convert.ToInt32(bin1, 2);
            n += Convert.ToInt32(bin2, 2);
            answer = Convert.ToString(n, 2);

            return answer;
        }
    }
}
