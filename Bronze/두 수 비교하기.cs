using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 두_수_비교하기
    {
        static void Main(string[] args)
        {
            int[] s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            if (s[0] == s[1])
            {
                Console.WriteLine("==");
            }
            else if(s[0] > s[1])
            {
                Console.WriteLine(">");
            }
            else 
            {
                Console.WriteLine("<");
            }
        }
    }
}
