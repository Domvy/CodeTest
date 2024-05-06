using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 컨트롤_제트
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string s = "1 2 Z 3";
            Console.WriteLine(solution.solution(s));
        }
    }
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;

            int z = 0;
            string[] array = s.Split(' ');
            foreach (string str in array) 
            {
                if (str.Equals("Z"))
                {
                    answer -= z;
                }
                else
                {
                    z = int.Parse(str);
                    answer += z;
                }
            }

            return answer;
        }
    }
}
