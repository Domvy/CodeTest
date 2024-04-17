using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 날짜_비교하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] date1 = { 2021, 12, 28 };
            int[] date2 = { 2021, 12, 29 };
            Console.WriteLine(solution.solution(date1, date2));
        }
    }
    public class Solution
    {
        public int solution(int[] date1, int[] date2)
        {
            int answer = 0;

            for (int i = 0; i < date1.Length; i++)
            {
                if (date1[i] < date2[i])
                {
                    return 1;
                }
                else if (date1[i] > date2[i])
                {
                    return 0;
                }
                else
                    continue;
            }
            return 0;
        }
    }
}
