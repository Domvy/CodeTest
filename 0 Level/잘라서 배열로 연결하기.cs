using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 잘라서_배열로_연결하기
{
    public class Solution
    {
        public string[] solution(string my_str, int n)
        {
            string[] answer = new string[] { };

            int arrayLength = my_str.Length / n;
            arrayLength += my_str.Length % n == 0 ? 0 : 1;
            answer = new string[arrayLength];
            int num = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = string.Concat(my_str.Skip(num).Take(n));
                num += n;
            }

            return answer;
        }
    }
}
