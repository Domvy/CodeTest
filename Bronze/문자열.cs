using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 문자열
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine($"{s[0]}{s[s.Length - 1]}");
            }
        }
    }
}
