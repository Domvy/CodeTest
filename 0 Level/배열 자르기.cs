using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열_자르기
{
    public class Solution
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int[] answer = new int[] { };

            answer = numbers.Where((x, Index) => num1 <= Index && Index <= num2).ToArray();

            return answer;
        }
    }
}
