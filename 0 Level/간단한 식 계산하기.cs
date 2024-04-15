using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 간단한_식_계산하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string binomial = "43 + 12";
            Console.WriteLine(solution.solution(binomial));
        }
    }
    public class Solution
    {
        public int solution(string binomial)
        {
            int answer = 0;

            string[] array = binomial.Split(' ');
            switch (array[1])
            {
                case "+":
                    answer = int.Parse(array[0]) + int.Parse(array[2]);
                    break;
                case "-":
                    answer = int.Parse(array[0]) - int.Parse(array[2]);
                    break;
                case "*":
                    answer = int.Parse(array[0]) * int.Parse(array[2]);
                    break;
            }

            return answer;
        }
    }
}
