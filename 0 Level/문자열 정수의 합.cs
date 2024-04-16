using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_정수의_합
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string num_str = "123456789";
            Console.WriteLine(solution.solution(num_str));
        }
    }
    public class Solution
    {
        public int solution(string num_str)
        {
            int answer = 0;

            int[] intArray = new int[num_str.Length];            
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(num_str[i].ToString());
            }
            answer = Enumerable.Sum(intArray);

            return answer;
        }
    }
}
