using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 세_개의_구분자
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string myStr = "baconlettucetomato";
            Console.WriteLine(solution.solution(myStr));
        }
    }
    public class Solution
    {
        public string[] solution(string myStr)
        {
            string[] answer = new string[] { };

            answer = myStr.Split(new char[] { 'a', 'b', 'c' }, StringSplitOptions.RemoveEmptyEntries);
            if (answer.Length < 1)
                answer = new string[] { "EMPTY" } ;
            

            return answer;
        }
    }
}
