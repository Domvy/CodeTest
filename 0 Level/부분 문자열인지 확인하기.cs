using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부분_문자열인지_확인하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "banana";
            string target = "ana";
            Console.WriteLine(solution.solution(my_string, target));
        }
    }
    public class Solution
    {
        public int solution(string my_string, string target)
        {
            int answer = 0;

            answer = my_string.Contains(target) ? 1 : 0;

            return answer;
        }
    }
}
