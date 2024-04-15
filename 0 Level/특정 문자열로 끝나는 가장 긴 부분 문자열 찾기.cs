using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특정_문자열로_끝나는_가장_긴_부분_문자열_찾기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "AbCdEFG";
            string pat = "dE";
            Console.WriteLine(solution.solution(my_string, pat));
        }
    }
    public class Solution
    {
        public string solution(string myString, string pat)
        {
            string answer = "";

            answer = myString.Substring(0, myString.LastIndexOf(pat) + pat.Length);
            
            return answer;
        }
    }
}
