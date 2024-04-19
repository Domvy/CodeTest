using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 최빈값_구하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] array = { 1, 2, 3, 3, 3, 4 };
            Console.WriteLine(solution.solution(array));
        }
    }

    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;

            int[] arrayNum = new int[array.Max() + 1];
            foreach (int i in array) 
            {
                arrayNum[i]++;
            }
            if (arrayNum.Where(x => x == arrayNum.Max()).Count() > 1)
            {
                return answer = -1;
            }
            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] == arrayNum.Max())
                {
                    return answer = i;
                }
            }
                

            return answer;
        }
    }
}
