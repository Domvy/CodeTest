using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_밀기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string A = "apple";
            string B = "elppa";
            Console.WriteLine(solution.solution(A,B));
        }
    }
    public class Solution
    {
        public int solution(string A, string B)
        {
            int answer = 0;

            int n = 0;
            int length = A.Length;
            while (n < length)
            {                
                if (A == B)
                {
                    answer = n;
                    break;
                }
                else
                {
                    answer = -1;
                }
                A = A.Substring(A.Length - 1) + A.Substring(0, A.Length - 1);                
                n++;
            }

            return answer;
        }
    }
}
