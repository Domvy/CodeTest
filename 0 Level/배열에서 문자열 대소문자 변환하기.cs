using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열에서_문자열_대소문자_변환하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] strArr = { "AAA", "BBB", "CCC", "DDD" };
            Console.WriteLine(solution.solution(strArr));
        }
    }
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            string[] answer = new string[] { };

            answer = new string[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                answer[i] = i % 2 == 1 ? strArr[i].ToUpper() : strArr[i].ToLower();
            }

            return answer;
        }
    }
}




