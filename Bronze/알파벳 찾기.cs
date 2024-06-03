using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 알파벳_찾기
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            int[] answer = Enumerable.Range(0, 26).ToArray();
            for (int i = 0; i < answer.Length; i++)
            {
                if (s.Contains((char)(answer[i] + 97)))
                {
                    answer[i] = s.IndexOf((char)(answer[i] + 97));
                }
                else
                    answer[i] = -1;
            }
            foreach (int n in answer)
            {
                sb.Append(n);
                sb.Append(' ');
            }
            Console.WriteLine(sb);
        }
    }
}
