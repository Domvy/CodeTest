using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 대문자로바꾸기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string myString = "aBcDeFg";
            Console.WriteLine(solution.solution(myString));
        }
    }
    public class Solution
    {
        public string solution(string myString)
        {
            string answer = "";

            answer = myString.ToUpper();

            return answer;
        }
    }
}



