using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정사각형으로_만들기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[,] arr = { { 572, 22, 37 }, { 287, 726, 384 }, { 85, 137, 292 }, { 487, 13, 876 } };
            Console.WriteLine(solution.solution(arr));
        }
    }
    public class Solution
    {
        public int[,] solution(int[,] arr)
        {
            int[,] answer = new int[,] { { } };

            if (arr.GetLength(0) < arr.GetLength(1))           
                answer = new int[arr.GetLength(1), arr.GetLength(1)];  
            else        
                answer = new int[arr.GetLength(0), arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    answer[i,j] = arr[i,j];
                }
            }

            return answer;
        }
    }
}
