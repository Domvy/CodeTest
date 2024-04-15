using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Level
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 5, 1, 4 };
            Console.WriteLine(solution.solution(arr));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };

            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    list.Add(arr[i]);
                }
            }
            answer = list.ToArray();

            return answer;
        }
    }
}
