using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 모스_부호
{
    public class Solution
    {
        public string solution(string letter)
        {
            string answer = "";

            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string[] letterArray = letter.Split(' ');
            for (int i = 0; i < letterArray.Length; i++)
            {
                answer += (char)(Array.IndexOf(morse, letterArray[i]) + 97);
            }

            return answer;
        }
    }
}
