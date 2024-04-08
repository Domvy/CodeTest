using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0q
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] str_list = { "u", "u", "l", "r" };

            Console.WriteLine(solution.solution(str_list));
        }
    }
    public class Solution
    {
        public string[] solution(string[] str_list)
        {
            string[] answer = new string[] { };

            int idx = 0;
            idx = str_list.Contains("l") ? Array.IndexOf(str_list, "l") : int.MaxValue;
            if (str_list.Length > 1)
            {
                if (str_list.Contains("r") && Array.IndexOf(str_list, "r") < idx)
                {
                    idx = Array.IndexOf(str_list, "r");
                    answer = str_list.Skip(idx + 1).ToArray();
                }
                else
                    answer = str_list.Take(idx).ToArray();
            }

            return answer;
        }
    }
}

