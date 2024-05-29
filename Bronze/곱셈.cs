using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 곱셈
    {
        static void Main(string[] args)
        {
            string u = Console.ReadLine();
            string d = Console.ReadLine();
            int numbersA = int.Parse(u);
            int[] numbersB = d.Select(x => int.Parse(x.ToString())).ToArray();

            Console.WriteLine(numbersB[2] * numbersA);
            Console.WriteLine(numbersB[1] * numbersA);
            Console.WriteLine(numbersB[0] * numbersA);
            Console.WriteLine(int.Parse(d) * numbersA);
        }
    }
}
