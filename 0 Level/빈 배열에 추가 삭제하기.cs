using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 빈_배열에_추가_삭제하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 3, 2, 4, 1, 3 };
            bool[] flag = { true, false, true, false, false };
            Console.WriteLine(solution.solution(arr, flag));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr, bool[] flag)
        {
            int[] answer = new int[] { };

            List<int> list = new List<int>();
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i])
                    list.AddRange(Enumerable.Repeat(arr[i], arr[i] * 2));
                else if (!flag[i])
                    list.RemoveRange(list.Count - arr[i], arr[i]);
            }
            answer = list.ToArray();

            return answer;
        }
    }
}
