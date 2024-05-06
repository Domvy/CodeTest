using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2차원으로_만들기
{
    public class Solution
    {
        public int[,] solution(int[] num_list, int n)
        {
            int[,] answer = new int[,] { { } };

            answer = new int[num_list.Length / n, n];
            int a= 0; int b=0;
            foreach (int i in num_list) 
            {
                if (b == n)
                {
                    ++a;
                    b = 0;
                }
                answer[a, b] = i;
                b++;
            }

            return answer;
        }
    }
}
