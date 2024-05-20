using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 직사각형_넓이_구하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[,] dots = { {1, 1}, { 2, 1 }, { 2, 2 }, { 1, 2 } };
            Console.WriteLine(solution.solution(dots));
        }
    }
    public class Solution
    {
        public int solution(int[,] dots)
        {
            int answer = 0;

            int xMax = int.MinValue;
            int xMin = int.MaxValue;
            int yMax = int.MinValue;
            int yMin = int.MaxValue;
            for (int i = 0; i < dots.GetLength(0); i++)
            {
                for (int j = 0; j < dots.GetLength(1); j++)
                {
                    xMax = dots[i, 0] > xMax ? dots[i, 0] : xMax;
                    xMin = dots[i, 0] < xMin ? dots[i, 0] : xMin;
                    yMax = dots[i, 1] > yMax ? dots[i, 1] : yMax;
                    yMin = dots[i, 1] < yMin ? dots[i, 1] : yMin;
                }
            }
            answer = (xMax - xMin) * (yMax - yMin);

            return answer;
        }
    }
}
