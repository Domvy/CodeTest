using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0j
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(123));
            Console.WriteLine(solution.solution(2573));
        }
    }
    public class Solution
    {
        public string solution(int n)
        {
            string answer = "";

            n.ToString();
            answer += n;

            return answer;
        }
    }

}
