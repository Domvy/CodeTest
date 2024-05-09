using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_계산하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string my_string = "1 - 20 + 30 + 4";
            Console.WriteLine(solution.solution(my_string));
        }
    }
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;

            Queue queue = new Queue();
            List<int> numbers = new List<int>();
            string[] stringArray = my_string.Split(' ');
            foreach (string str in stringArray)
            {
                if (str.Equals("+") || str.Equals("-"))
                {
                    queue.Enqueue(str);
                }
                else
                    numbers.Add(int.Parse(str));
            }
            int n = 1;
            answer += numbers[0];
            while (queue.Count > 0)
            {
                if ((string)queue.Dequeue() == "+")
                    answer += numbers[n];
                else
                    answer -= numbers[n];
                n++;
            }

            return answer;
        }
    }
}
