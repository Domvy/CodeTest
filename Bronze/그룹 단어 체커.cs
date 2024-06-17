using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 그룹_단어_체커
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            int n = 0;
            for (int k = 0; k < line; k++)
            {
                string s = Console.ReadLine();
                char c = ' ';
                for (int i = 0; i < s.Length; i++)
                {
                    if (c != s[i])
                    {
                        c = s[i];
                    }
                    else
                    {
                        s = s.Remove(i, 1);
                        i--;
                    }                        
                }
                n++;
                foreach (char ch in s)
                {
                    if (s.IndexOf(ch) != s.LastIndexOf(ch))
                    {
                        n--;
                        break;
                    }
                }
            }
            Console.WriteLine($"{n}");
        }
    }
}
