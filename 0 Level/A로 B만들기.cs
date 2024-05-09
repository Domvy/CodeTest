using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A로_B만들기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string before = "olleh";
            string after = "hello";
            Console.WriteLine(solution.solution(before, after));
        }
    }
    public class Solution
    {
        public int solution(string before, string after)
        {
            int answer = 1;

            for (int i = 0; i < before.Length; i++)
            {                
                if (after.Contains(before[i]))
                {
                    int idx = after.IndexOf(before[i]);
                    after = after.Remove(idx, 1);
                }
                else
                {
                    answer = 0;
                    break;
                }                                    
            }

            return answer;
        }
    }
}
