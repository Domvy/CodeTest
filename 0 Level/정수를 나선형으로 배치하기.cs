using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정수를_나선형으로_배치하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int n = 4;
            Console.WriteLine(solution.solution(n));
        }
    }
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];

            int count = 1;
            int leftn = answer.GetLength(0);
            int curX = 0;
            int curY = 0;
            while (leftn > 0)
            {
                for (int i = 0; i < leftn; i++)
                {
                    answer[curY, curX++] = count++;
                }
                leftn -= 1;
                curX -= 1;
                curY += 1;
                for (int j = 0; j < leftn; j++)
                {
                    answer[curY++, curX] = count++;
                }
                curY -= 1;
                curX -= 1;
                for (int k = 0; k < leftn; k++)
                {
                    answer[curY, curX--] = count++;
                }
                leftn -= 1;
                curY -= 1;
                curX += 1;
                for (int h = 0; h < leftn; h++)
                {
                    answer[curY--, curX] = count++;
                }
                curY += 1;
                curX += 1;
            }
            return answer;
        }
    }
}
