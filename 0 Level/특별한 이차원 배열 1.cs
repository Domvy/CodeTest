using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특별한_이차원_배열_1
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int n = 3;
            Console.WriteLine(solution.solution(n));
        }
    }
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n,n];

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i,j] = i == j ? 1 : 0;
                }
            }

            return answer;
        }
    }
}
