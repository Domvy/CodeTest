using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자_반복_출력하기
{
    public class Solution
    {
        public string solution(string my_string, int n)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(my_string[i]);
                }
            }
            answer = sb.ToString();

            return answer;
        }
    }
}
