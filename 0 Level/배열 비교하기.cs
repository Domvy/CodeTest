using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 배열_비교하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr1 = { 49, 13 };
            int[] arr2 = { 70, 11, 2 };
            Console.WriteLine(solution.solution(arr1, arr2));
        }
    }
    public class Solution
    {
        public int solution(int[] arr1, int[] arr2)
        {
            int answer = 0;

            if (arr1.Length != arr2.Length)
            {
                answer = arr1.Length < arr2.Length ? -1 : 1;
            }
            else
            {
                int a = Enumerable.Sum(arr1);
                int b = Enumerable.Sum(arr2);

                if (a == b)
                    answer = 0;
                else
                    answer = a < b ? -1 : 1;

            }

            return answer;
        }
    }
}
