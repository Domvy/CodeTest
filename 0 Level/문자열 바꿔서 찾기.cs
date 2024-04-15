using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_바꿔서_찾기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string myString = "ABBAA";
            string pat = "AABB";
            Console.WriteLine(solution.solution(myString, pat));
        }
    }
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;

            answer = myString.ToLower().Replace('a', 'B').Replace('b', 'A').Contains(pat) ? 1 : 0;
            

            return answer;
        }
    }
}
