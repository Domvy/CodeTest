using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 조건에맞게수열변환하기2
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
        public int solution(int[] arr)
        {
            int answer = 0;

            int x = 0;
            int[] array = new int[arr.Length];
            while (true) 
            {   
                for (int i = 0; i < arr.Length; i++)
                {
                    array[i] = arr[i] >= 50 ?
                        arr[i] % 2 == 0 ? arr[i] / 2 : arr[i] :
                        arr[i] % 2 == 1 ? arr[i] * 2 + 1 : arr[i];
                }
                if (Enumerable.SequenceEqual(arr,array))
                {
                    answer = x;
                    break;
                }
                arr = (int[])array.Clone();
                x++;
            }

            return answer;
        }
    }
}


