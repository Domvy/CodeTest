using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0v
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 4, 2, 6, 1, 7, 6 };
            Console.WriteLine(solution.solution(num_list));
        }
    }
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;

            int a = Enumerable.Sum(num_list.Where((x, Index) => Index % 2 == 1));
            int b = Enumerable.Sum(num_list.Where((x, Index) => Index % 2 == 0));
            answer = a <= b ? b : a;

            return answer;
        }
    }

}
