using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 꼬리_문자열
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] str_list = { "abc", "def", "ghi" };
            string ex = "ef";
            Console.WriteLine(solution.solution(str_list, ex));
        }
        public class Solution
        {
            public string solution(string[] str_list, string ex)
            {
                string answer = "";

                for (int i = 0; i < str_list.Length; i++)
                {
                    answer += str_list[i].Contains(ex) ? "" : str_list[i];
                }

                return answer;
            }
        }
    }
}
