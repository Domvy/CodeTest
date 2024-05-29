using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 영수증
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += Console.ReadLine().Split().Select(int.Parse).Aggregate((x, y) => x * y);
            }
            string result = sum == max ? "Yes" : "No";
            Console.WriteLine(result);
        }
    }
}
