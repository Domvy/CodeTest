using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열의_원소_삭제하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 293, 1000, 395, 678, 94 };
            int[] delete_list = { 94, 777, 104, 1000, 1, 12 };
            Console.WriteLine(solution.solution(arr, delete_list));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr, int[] delete_list)
        {
            int[] answer = new int[] { };

            answer = arr.Where(x => !delete_list.Contains(x)).ToArray();

            return answer;
        }
    }
}
