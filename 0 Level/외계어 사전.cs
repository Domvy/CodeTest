using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 외계어_사전
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] spell = { "p", "o", "s" };
            string[] dic = { "sod", "eocd", "qixm", "adio", "soo" };
            Console.WriteLine(solution.solution(spell, dic));
        }
    }
    public class Solution
    {
        public int solution(string[] spell, string[] dic)
        {
            int answer = 0;
            
            foreach (string s in dic) 
            {
                foreach (string c in spell)
                {
                    if (s.Contains(c) && s.IndexOf(c) == s.LastIndexOf(c))                   
                        answer = 1;
                    else
                    {
                        answer = 2;
                        break;
                    }                        
                }
                if (answer == 1)
                    break;
            }            

            return answer;
        }
    }
}
