using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 그림_확대
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] picture = { ".xx...xx.", "x..x.x..x", "x...x...x", ".x.....x.", "..x...x..", "...x.x...", "....x...." };
            int k = 2;
            Console.WriteLine(solution.solution(picture, k));
        }
    }
    public class Solution
    {
        public string[] solution(string[] picture, int k)
        {
            string[] answer = new string[picture.Length * k];

            int idx = 0;
            StringBuilder sb = new StringBuilder();
            foreach (string s in picture)
            {
                sb = new StringBuilder();
                foreach (char c in s)
                {
                    for (int i = 0; i < k; i++)
                        sb.Append(c);
                }
                for (int i = 0; i < k; i++)
                {
                    answer[idx++] = sb.ToString();
                }
            }

            return answer;
        }
    }
}
