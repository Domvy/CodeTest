using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 숫자의_합
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            Console.WriteLine(Enumerable.Sum(numbers, x => int.Parse(x.ToString())));
        }
    }
}
