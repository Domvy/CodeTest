using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 영어가_싫어요
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string numbers = "onetwothreefourfivesixseveneightnine";
            Console.WriteLine(solution.solution(numbers));
        }
    }
    public class Solution
    {
        public long solution(string numbers)
        {
            long answer = 0;

            string[] numbersList = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int n = 0;
            while (n < numbersList.Length) 
            {
                if (numbers.Contains(numbersList[n])) 
                {
                    numbers = numbers.Replace(numbersList[n], n.ToString());
                }
                n++;
            }
            answer = long.Parse(numbers);

            return answer;
        }
    }
}
