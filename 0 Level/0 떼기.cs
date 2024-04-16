using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_떼기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string n_str = "0010";
            Console.WriteLine(solution.solution(n_str));
        }
    }
    public class Solution
    {
        public string solution(string n_str)
        {
            string answer = "";

            while (n_str[0].CompareTo('0') == 0)
            {
                n_str = n_str.Remove(0, 1);
            }
            answer = n_str;
            return answer;
        }
    }
}
