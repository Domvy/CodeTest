using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 치킨_쿠폰
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int chicken = 100;
            Console.WriteLine(solution.solution(chicken));
        }
    }
    public class Solution
    {
        public int solution(int chicken)
        {
            int answer = 0;

            while(chicken >= 10)
            {
                answer += chicken / 10;
                chicken = chicken / 10 + chicken % 10;
            }

            return answer;
        }
    }
}
