using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ad_제거하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] strArr = { "and", "notad", "abcd" };
            Console.WriteLine(solution.solution(strArr));
        }
    }
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            string[] answer = new string[] { };

            answer = strArr.Where(x => !x.Contains("ad")).ToArray();

            return answer;
        }
    }
}
