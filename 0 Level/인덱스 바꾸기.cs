using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인덱스_바꾸기
{
    public class Solution
    {
        public string solution(string my_string, int num1, int num2)
        {
            string answer = "";

            char[] charArray = my_string.ToCharArray();
            char temp = charArray[num1];
            charArray[num1] = charArray[num2];
            charArray[num2] = temp;
            answer = string.Concat(charArray);

            return answer;
        }
    }
}
