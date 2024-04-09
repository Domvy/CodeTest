using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 일로만들기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 12, 4, 15, 1, 14 };
            Console.WriteLine(solution.solution(num_list));
        }
    }
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;

            for (int i = 0; i < num_list.Length; i++)
            {
                int x = 0;
                x = num_list[i];
                while (x != 1)
                {
                    x = x % 2 == 0 ? x / 2 : (x - 1) / 2;
                    answer++;
                }
            }

            return answer;
        }
    }
}



