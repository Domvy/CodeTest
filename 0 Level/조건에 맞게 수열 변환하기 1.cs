using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level0y
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 1, 2, 3, 100, 99, 98 };
            Console.WriteLine(solution.solution(arr));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };

            answer = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] < 50 ?
                    arr[i] % 2 == 1 ? arr[i] * 2 : arr[i] :
                    arr[i] % 2 == 0 ? arr[i] / 2 : arr[i];
            }

            return answer;
        }
    }

}

