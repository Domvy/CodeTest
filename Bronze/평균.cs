using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 평균
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            numbers = numbers.Select(x => x / numbers.Max() * 100).ToArray();
            Console.WriteLine($"{Enumerable.Sum(numbers) / count}");
        }
    }
}
