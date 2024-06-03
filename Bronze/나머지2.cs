using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 나머지2
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int count = 10;
            int[] numbers = new int[count];
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            result = numbers.Select(x => x % 42).Distinct().Count();
            Console.WriteLine(result);
        }
    }
}
