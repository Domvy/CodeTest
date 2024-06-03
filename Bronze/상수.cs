using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 상수
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').
                Select(x => string.Concat( x.Reverse())).Select(int.Parse).ToArray();
            Console.WriteLine($"{numbers.Max()}");
        }
    }
}
