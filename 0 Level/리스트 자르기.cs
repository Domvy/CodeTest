using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0i
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int n = 3;
            int[] slicer = { 1, 5, 2 };
            int[] num_list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(solution.solution(n, slicer, num_list));
        }
    }
    public class Solution
    {
        public int[] solution(int n, int[] slicer, int[] num_list)
        {
            int[] answer = new int[] { };

            int a, b, c;
            a = slicer[0];
            b = slicer[1];
            c = slicer[2];

            switch (n)
            {
                case 1:
                    answer = num_list.Take(b + 1).ToArray();
                    break;
                case 2:
                    answer = num_list.Skip(a).ToArray();
                    break;
                case 3:
                    answer = num_list.Skip(a).Take(b + 1 - a).ToArray();
                    break;
                case 4:
                    answer = num_list.Skip(a).Take(b + 1 - a).
                        Where((x, Index) => Index % c == 0).ToArray();
                    break;
            }

            return answer;
        }
    }

}
