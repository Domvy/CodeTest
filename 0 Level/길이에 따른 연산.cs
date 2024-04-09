using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 길이에따른연산
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] num_list = { 3, 4, 5, 2, 5, 4, 6, 7, 3, 7, 2, 2, 1 };
            Console.WriteLine(solution.solution(num_list));
        }
    }
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;

            if (num_list.Length < 11)
            {                
                answer = num_list.Aggregate((x, y) => x * y);
            }
            else
            {
                answer = Enumerable.Sum(num_list);
            }

            return answer;
        }
    }
}



