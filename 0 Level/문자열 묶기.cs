using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_묶기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] strArr = { "a", "bc", "d", "efg", "hi" };            
            Console.WriteLine(solution.solution(strArr));
        }
    }
    public class Solution
    {
        public int solution(string[] strArr)
        {
            int answer = 0;

            answer = strArr.GroupBy(x => x.Length).OrderBy(x => x.Count()).Last().Count();
            
            return answer;
        }
    }
}
