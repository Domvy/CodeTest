using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I로_만들기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string myString = "abcdevwxyz";
            Console.WriteLine(solution.solution(myString));
        }
    }
    public class Solution
    {
        public string solution(string myString)
        {
            string answer = "";

            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] < 'l')
                {
                    answer += 'l';
                }
                else
                    answer += myString[i];
            }
            

            return answer;
        }
    }
}
