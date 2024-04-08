using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0b
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] names = { "nami", "ahri", "jayce", "garen", "ivern", "vex", "jinx" };
            Console.WriteLine(solution.solution(names));
        }
    }
    public class Solution
    {
        public string[] solution(string[] names)
        {
            string[] answer = new string[] { };

            answer = names.Where((x, Index) => Index % 5 == 0).ToArray();

            return answer;
        }
    }
}

