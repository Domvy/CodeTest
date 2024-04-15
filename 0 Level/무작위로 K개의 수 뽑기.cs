using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 무작위로_K개의_수_뽑기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 0, 1, 1, 2, 2, 3 };
            int k = 3;
            Console.WriteLine(solution.solution(arr, k));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            int[] answer = new int[] { };

            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!list.Contains(arr[i]) && list.Count < k)
                    list.Add(arr[i]);
            }
            if (list.Count < k)            
                list.AddRange(Enumerable.Repeat(-1, k - list.Count));
            
            answer = list.ToArray();

            return answer;
        }
    }
}
