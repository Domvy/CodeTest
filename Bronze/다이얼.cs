using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 다이얼
    {
        static void Main(string[] args)
        {
            string[] s = { "ABC", "DEF", "GHI","JKL","MNO","PQRS","TUV","WXYZ" };
            string answer = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j].Contains(answer[i]))
                    {
                        result += j + 3;
                    } 
                }
            }
            Console.WriteLine(result);
        }
    }
}
