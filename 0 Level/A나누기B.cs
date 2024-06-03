using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class A나누기B
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine((double.Parse(s[0]) / double.Parse(s[1])));
        }
    }
}
