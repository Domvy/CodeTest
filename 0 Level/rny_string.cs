using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rny_string
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string rny_string = "masterpiece";           
            Console.WriteLine(solution.solution(rny_string));
        }
    }
    public class Solution
    {
        public string solution(string rny_string)
        {
            string answer = "";

            string[] strArray = rny_string.Split();
            foreach (string s in strArray)
            {
                answer += s.Replace("m", "rn");            
            }

            return answer;
        }
    }
}
