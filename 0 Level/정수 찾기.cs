using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정수_찾기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 1, 2, 3, 4, 5 };
            int n = 3;
            Console.WriteLine(solution.solution(num_list, n));
        }
    }    
    public class Solution
    {
        public int solution(int[] num_list, int n)
        {
            int answer = 0;

            answer = num_list.Contains(n) ? 1 : 0;

            return answer;
        }
    }
}
