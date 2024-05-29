using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class A곱하기B
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
        }
    }
}
