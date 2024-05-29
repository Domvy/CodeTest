using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 시험_성적
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (90 <= n)
            {
                Console.WriteLine("A");
            }
            else if(80 <= n)
            {
                Console.WriteLine("B");
            }
            else if(70 <= n)
            {
                Console.WriteLine("C");
            }
            else if(60 <= n)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");
            }
        }
    }
}
