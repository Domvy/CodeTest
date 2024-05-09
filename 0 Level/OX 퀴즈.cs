using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OX_퀴즈
{
    public class Solution
    {
        public string[] solution(string[] quiz)
        {
            string[] answer = new string[] { };

            answer = new string[quiz.Length];
            string[] stringArray = new string[] { };
            for (int i = 0; i < quiz.Length; i++)
            {
                stringArray = quiz[i].Split(' ');
                int result = int.Parse(stringArray.Last());
                int number = 0;
                bool add = true;
                for (int j = 0; j < stringArray.Length - 2; j++)
                {
                    if (stringArray[j].Equals("+") || stringArray[j].Equals("-"))                    
                        add = stringArray[j].Equals("+") ? true : false;                    
                    else
                    {
                        if (add)                        
                            number += int.Parse(stringArray[j]);                        
                        else
                            number -= int.Parse(stringArray[j]);
                    }
                }
                answer[i] = result == number ? "O" : "X";
            }

            return answer;
        }
    }
}
