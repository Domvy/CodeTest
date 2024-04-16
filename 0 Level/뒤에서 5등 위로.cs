using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 뒤에서_5등_위로
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 12, 4, 15, 46, 38, 1, 14, 56, 32, 10 };            
            Console.WriteLine(solution.solution(num_list));
        }
    }
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[] { };

            answer = num_list.OrderBy(x => x).Where((x, Index) => Index >= 5).ToArray();

            return answer;
        }
    }
}
