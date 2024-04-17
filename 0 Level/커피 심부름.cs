using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 커피_심부름
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] order = { "cafelatte", "americanoice", "hotcafelatte", "anything" };
            Console.WriteLine(solution.solution(order));
        }
    }
    public class Solution
    {
        public int solution(string[] order)
        {
            int answer = 0;

            foreach (var item in order) 
            {
                answer += item.Contains("cafelatte") ? 5000 : 4500;
            }

            return answer;
        }
    }
}
