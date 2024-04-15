using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열의_길이를_2의_거듭제곱으로_만들기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(solution.solution(arr));
        }
    }
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };

            int n = 0;
            List<int> list = new List<int>();
            list.AddRange(arr);
            while (Math.Pow(2, n) < arr.Length)
                n++;
            for (int i = 0; i < Math.Pow(2,n) - arr.Length; i++)            
                list.Add(0);            
            answer = list.ToArray();

            return answer;
        }
    }
}
