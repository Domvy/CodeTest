using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 짝수는_싫어요
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int n = 10;
            Console.WriteLine(solution.solution(n));
        }
    }
    public class Solution
    {
        public int[] solution(int n)
        {
            int[] answer = new int[] { };

            int[] array = new int[n + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            answer = array.Where(x => x % 2 == 1).ToArray();

            return answer;
        }
    }
}
