using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다항식_더하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string polynomial = "11x + 22x + 33x";
            Console.WriteLine(solution.solution(polynomial));
        }
    }
    public class Solution
    {
        public string solution(string polynomial)
        {
            string answer = "";

            int x = 0;
            int num = 0;
            string[] stringArray = polynomial.Split(' ');
            foreach (string str in stringArray)
            {
                if (str.Contains('x'))
                {
                    if (str.Length != 1)
                        x += int.Parse(str.Substring(0, str.Length - 1));
                    else
                        x += 1;
                }
                else if (!str.Contains('+'))
                    num += int.Parse(str);
            }
            answer += x > 1 ? $"{x}x" : x == 1 ? $"x" : "";
            answer += x != 0 && num != 0 ? " + " : "";
            answer += num != 0 ? $"{num}" : "";

            return answer;
        }
    }
}
