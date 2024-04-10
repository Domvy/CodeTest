using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특정한_문자를_대문자로_바꾸기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "programmers";
            string alp = "p";
            Console.WriteLine(solution.solution(my_string, alp));
        }
    }
    public class Solution
    {
        public string solution(string my_string, string alp)
        {
            string answer = "";

            answer = my_string.Replace(alp, alp.ToUpper());

            return answer;
        }
    }
}
