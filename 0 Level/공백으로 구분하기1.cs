using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 공백으로_구분하기1
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "i love you";
            Console.WriteLine(solution.solution(my_string));
        }
    }
    public class Solution
    {
        public string[] solution(string my_string)
        {
            string[] answer = new string[] { };

            answer = my_string.Split(' ');

            return answer;
        }
    }
}
