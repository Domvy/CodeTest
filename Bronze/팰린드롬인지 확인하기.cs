using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 팰린드롬인지_확인하기
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int answer = 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[(s.Length - 1) - i])
                {
                    continue;
                }
                else
                {
                    answer = 0; 
                    break;
                }                    
            }
            Console.WriteLine($"{answer}");
        }
    }
}
