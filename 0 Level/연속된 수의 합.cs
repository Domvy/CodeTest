using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연속된_수의_합
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int num = 4;
            int total = 14;
            Console.WriteLine(solution.solution(num, total));
        }
    }
    public class Solution
    {
        public int[] solution(int num, int total)
        {
            int[] answer = new int[] { };

            answer = new int[num];
            int middle = total / num;
            if (num % 2 == 1)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = middle - (num / 2) + i;
                }
            }
            else
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = middle - (num / 2 - 1) + i;
                }
            }


            return answer;
        }
    }
}
