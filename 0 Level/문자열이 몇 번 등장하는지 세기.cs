using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열이_몇_번_등장하는지_세기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "aaaa";
            string pat = "aa";
            Console.WriteLine(solution.solution(my_string, pat));
        }
    }

    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;

            int N = 0;
            while (true)                
            {                
                if (myString.Contains(pat))
                {
                    N = myString.IndexOf(pat);
                    myString = myString.Substring(N + 1);
                    answer++;
                }
                else
                {
                    break;
                }
            }            

            return answer;
        }
    }
}
