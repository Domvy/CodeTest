using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 사칙연산
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine((int.Parse(s[0]) + int.Parse(s[1])));            
            Console.WriteLine((int.Parse(s[0]) - int.Parse(s[1])));
            Console.WriteLine((int.Parse(s[0]) * int.Parse(s[1])));
            Console.WriteLine((int.Parse(s[0]) / int.Parse(s[1])));
            Console.WriteLine((int.Parse(s[0]) % int.Parse(s[1])));
        }
    }
}
