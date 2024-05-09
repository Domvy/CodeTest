using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k의_개수
{
    public class Solution
    {
        public class Program
        {
            public static void Main()
            {
                Solution solution = new Solution();
                int i = 1;
                int j = 13;
                int k = 1;
                Console.WriteLine(solution.solution(i, j, k));
            }
        }
        public int solution(int i, int j, int k)
        {
            int answer = 0;

            while (i <= j)
            {
                int n = i;
                do
                {
                    answer += n % 10 == k ? 1 : 0;
                    n = n / 10;
                } while (n > 0);
                i++;
            }

            return answer;
        }
    }
}
