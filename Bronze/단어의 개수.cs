using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 단어의_개수
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine($"{strings.Length}");
        }
    }
}
