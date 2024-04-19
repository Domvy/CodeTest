using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 피자_나눠_먹기_1
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int n = 7;
            Console.WriteLine(solution.solution(n));
        }
    }
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            int pizza = 0;
            int cut = 7;
            while (true)
            {
                ++pizza;
                if (pizza * cut / n > 0)
                {
                    return pizza;
                }
            }
            

            return answer;
        }
    }
}
