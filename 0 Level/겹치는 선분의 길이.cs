using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 겹치는_선분의_길이
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[,] lines = { { -1, 1 }, { 1, 3 }, { 3, 9 } };
            Console.WriteLine(solution.solution(lines));
        }
    }
    public class Solution
    {
        public int solution(int[,] lines)
        {
            int answer = 0;

            int[] numbersN = new int[101];
            int[] numbersP = new int[101];
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                int start = lines[i, 0];
                int end = lines[i, 1];

                if (start < 0)                
                    numbersN[-start]++;               
                else if (start >= 0)                
                    numbersP[start]++;                
                if (end < 0)                
                    numbersN[-end]--;                
                else if(end >= 0)                
                    numbersP[end]--;                
            }
            int now = 0;
            for (int j = numbersN.Length - 1; j > 0; j--)
            {
                now += numbersN[j];
                numbersN[j] = now;
            }
            for (int k = 0; k < numbersP.Length; k++)
            {
                now += numbersP[k];
                numbersP[k] = now;
            }
            answer = numbersP.Where(x => x >= 2).Count() + numbersN.Where(x => x >= 2).Count();

            return answer;
        }
    }
}
