using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_잘라서_정렬하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "axbxcxdx";
            Console.WriteLine(solution.solution(my_string));
        }
    }
    public class Solution
    {
        public string[] solution(string myString)
        {
            string[] answer = new string[] { };

            answer = myString.Split(new char[] { 'x' } ,StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(answer);

            return answer;
        }
    }
}
