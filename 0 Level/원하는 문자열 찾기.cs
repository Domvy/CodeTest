using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 원하는문자열찾기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string myString = "AbCdEfG";
            string pat = "aBc";
            Console.WriteLine(solution.solution(myString, pat));
        }
    }
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;

            answer = myString.ToLower().Contains(pat.ToLower()) ? 1 : 0;

            return answer;
        }
    }
}



