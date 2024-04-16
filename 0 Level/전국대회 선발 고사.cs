using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 전국대회_선발_고사
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] rank = { 3, 7, 2, 5, 4, 6, 1 };
            bool[] attendance = { false, true, true, true, true, false, false };
            Console.WriteLine(solution.solution(rank, attendance));
        }
    }
    public class Solution
    {
        public int solution(int[] rank, bool[] attendance)
        {
            int answer = 0;

            int[] array = new int[] { };
            array = rank.Where((x, Index) => attendance[Index] == true).OrderBy(x => x).Take(3).
                Select(x => Array.IndexOf(rank ,x)).ToArray();
            answer = 10000 * array[0] + 100 * array[1] + array[2];


            return answer;
        }
    }
}
