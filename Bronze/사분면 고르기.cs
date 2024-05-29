using System;
using System.Collections.Generic;
using System.Linq;

namespace Bronze
{
    internal class 사분면_고르기
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x * y > 0)
            {
                if (0 < x)
                {
                    Console.WriteLine(1);
                }
                else
                    Console.WriteLine(3);
            }
            else
            {
                if (x < 0)
                {
                    Console.WriteLine(2);
                }
                else
                    Console.WriteLine(4);
            }
        }                        
    }
}
