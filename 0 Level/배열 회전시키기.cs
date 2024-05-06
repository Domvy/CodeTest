using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열_회전시키기
{
    public class Solution
    {
        public int[] solution(int[] numbers, string direction)
        {
            int[] answer = new int[] { };

            int dir = 0;
            int n = 0;
            answer = new int[numbers.Length];
            dir = direction.Equals("right") ? -1 : 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (n == 0 && dir == -1)
                    answer[n] = numbers[numbers.Length - 1];
                else if (n == numbers.Length - 1 && dir == 1)
                    answer[n] = numbers[0];
                else
                    answer[n] = numbers[n + dir];
                n++;
            }


            return answer;
        }
    }
}
