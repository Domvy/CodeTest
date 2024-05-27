using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 옹알이_1
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] babbling = { "aya", "yee", "u", "maa", "wyeoo" };
            Console.WriteLine(solution.solution(babbling));
        }
    }
    public class Solution
    {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string[] array = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {                    
                    if (babbling[i].Contains(array[j]))
                    {
                        babbling[i] = babbling[i].Replace(array[j], " ");
                    }
                    if (babbling[i].Replace(" ", "") == "")
                    {
                        answer++;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
