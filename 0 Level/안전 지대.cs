using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안전_지대
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[,] board = { { 1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            Console.WriteLine(solution.solution(board));
        }
    }
    public class Solution
    {
        public int solution(int[,] board)
        {
            int answer = 0;

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[i, j] == 1)
                    {
                        int x = j - 1;
                        int y = i - 1;
                        for (int n = 0; n < 9; n++)
                        {
                            if (x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1))
                            {
                                if (board[y, x] == 0)                                
                                    board[y, x] = 2;                                                                
                            }
                            if (x < j + 1)
                            {
                                x += 1;
                            }
                            else
                            {
                                x = j - 1;
                                y++;
                            }
                        }
                    }
                    else
                        continue;
                }
            }
            foreach (int num in board) 
            {
                if (num == 0)
                    answer++;
            }

            return answer;
        }
    }
}
