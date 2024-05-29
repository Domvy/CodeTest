using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 윤년
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 4 == 0 && n % 100 != 0)
            {
                Console.WriteLine(1);
            }
            else if (n % 4 == 0 && n % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(0);
        }
    }
}
