using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace 피자_나눠_먹기_3
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int slice = 7;
            int n = 10;
            Console.WriteLine(solution.solution(slice, n));
        }
    }
    public class Solution
    {
        public int solution(int slice, int n)
        {            
            int pizza = 0;
            while (!(pizza * slice / n > 0)) 
            {
                ++pizza;
            }

            return pizza;
        }
    }
}
