using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열의_길이에_따라_다른_연산하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 49, 12, 100, 276, 33 };
            int n = 27;
            Console.WriteLine(solution.solution(arr, n));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr, int n)
        {
            int[] answer = new int[] { };

            int a = 0;
            a = arr.Length % 2 == 0 ? 1 : 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == a)
                {
                    arr[i] = arr[i] + n;
                }                
            }
            answer = arr;

            return answer;
        }
    }
}
