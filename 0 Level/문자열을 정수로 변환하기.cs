using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열을_정수로_변환하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string n_str = "10";
            Console.WriteLine(solution.solution(n_str));
        }
    }
    public class Solution
    {
        public int solution(string n_str)
        {
            int answer = 0;

            answer = int.Parse(n_str);

            return answer;
        }
    }
}
