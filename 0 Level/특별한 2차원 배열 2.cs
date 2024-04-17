using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특별한_2차원_배열_2
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[,] arr = { { 19, 498, 258, 587 }, { 63, 93, 7, 754 }, { 258, 7, 1000, 723 } , { 587, 754, 723, 81 } };
            Console.WriteLine(solution.solution(arr));
        }
    }
    public class Solution
    {
        public int solution(int[,] arr)
        {
            int answer = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != arr[j, i])
                        return 0;                    
                }
            }
            return 1;
        }
    }
}
