using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정수_부분
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            double flo = 1.42f;
            Console.WriteLine(solution.solution(flo));
        }
    }
    public class Solution
    {
        public int solution(double flo)
        {
            int answer = 0;

            answer = (int)flo;

            return answer;
        }
    }
}
