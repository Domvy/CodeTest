using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 저주의_숫자_3
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int n = 15;
            Console.WriteLine(solution.solution(n));
        }
    }
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            int[] numbers = Enumerable.Range(1, n * 3).Where(x => x % 3 != 0).Where(x => !x.ToString().Contains("3")).ToArray();
            answer = numbers[n - 1];

            return answer;
        }
    }
}
