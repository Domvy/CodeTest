using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 외계행성의_나이
{
    public class Solution
    {
        public string solution(int age)
        {
            string answer = "";
            
            while (0 < age)             
            {
                int a = age % 10;
                answer += (char)(a + 97);
                age = age / 10;
            }
            string newStr = new string(answer.Reverse().ToArray());

            return newStr;
        }
    }
}
