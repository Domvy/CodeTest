using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_강조하기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string myString = "abstract algebra";
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
                if (myString[i].ToString().Equals("a"))
                {
                    answer += Char.ToUpper(myString[i]);
                }
                else if (Char.IsUpper(myString[i]) && !myString[i].ToString().Equals("A"))
                {
                    answer += Char.ToLower(myString[i]);
                }
                else
                    answer += myString[i];
            }

            return answer;
        }
    }
}
