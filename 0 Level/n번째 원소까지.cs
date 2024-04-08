using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0d
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 2, 1, 6 };
            int n = 1;
            Console.WriteLine(solution.solution(num_list, n));
        }
    }
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            int[] answer = new int[] { };

            answer = num_list.Take(n).ToArray();

            return answer;
        }
    }

}
