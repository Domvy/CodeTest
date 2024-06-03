using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 문자와_문자열
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(s[count - 1]);
        }
    }
}
