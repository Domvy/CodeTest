using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특이한_정렬
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] numlist = { 10000, 20, 36, 47, 40, 6, 10, 7000 };
            int n = 30;
            Console.WriteLine(solution.solution(numlist, n));
        }
    }
    public class Solution
    {
        public int[] solution(int[] numlist, int n)
        {
            int[] answer = new int[] { };

            answer = numlist.OrderBy(x => Math.Abs(n - x)).ToArray();
            for (int i = 0; i + 1 < answer.Length; i++)
            {
                if (Math.Abs(answer[i] - n) == Math.Abs(answer[i + 1] - n)
                    && answer[i] < answer[i + 1])
                {
                    int temp = answer[i];
                    answer[i] = answer[i + 1];
                    answer[i + 1] = temp;
                }
            }

            return answer;
        }
    }
}
