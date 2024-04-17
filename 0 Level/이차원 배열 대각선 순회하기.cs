using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이차원_배열_대각선_순회하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[,] board = { { 0, 1, 2 }, { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            int k = 2;
            Console.WriteLine(solution.solution(board, k));
        }
    }
    public class Solution
    {
        public int solution(int[,] board, int k)
        {
            int answer = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    answer += i + j <= k ? board[i, j] : 0;
                }
            }

            return answer;
        }
    }
}
