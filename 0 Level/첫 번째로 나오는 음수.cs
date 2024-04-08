using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0t
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 12, 4, 15, 46, 38, -2, 15 };
            Console.WriteLine(solution.solution(num_list));
        }
    }
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;

            int idx = 0;
            foreach (int i in num_list)
            {
                answer = i * -1 >= 0 ? idx : -1;
                if (answer != -1) break;
                idx++;
            }

            return answer;
        }
    }

}
