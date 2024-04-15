using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_사이의_개수
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "oxooxoxxox";
            Console.WriteLine(solution.solution(my_string));
        }
    }
    public class Solution
    {
        public int[] solution(string myString)
        {
            int[] answer = new int[] { };

            string[] array = new string[] { };
            array = myString.Split('x');
            answer = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i] = array[i].Length;
            }

            return answer;
        }
    }
}
