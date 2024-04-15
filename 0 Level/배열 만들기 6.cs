using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열_만들기_6
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 0, 1, 1, 1, 0 };            
            Console.WriteLine(solution.solution(arr));
        }
        public class Solution
        {
            public int[] solution(int[] arr)
            {
                int[] answer = new int[] { };

                List<int> list = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (list.Count == 0 || list[list.Count - 1] != arr[i])
                        list.Add(arr[i]);
                    else
                        list.RemoveAt(list.Count - 1);
                }                
                answer = list.ToArray();
                

                return answer = answer.Length == 0 ? new int[] { -1 } : answer;
            }
        }
    }
}
