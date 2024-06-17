using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 킹퀸룩비숍나이트폰
    {
        static void Main(string[] args)
        {
            int[] chess = { 1, 1, 2, 2, 2, 8 };
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = chess.Select((x, Index) => x - numbers[Index]).ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (int i in result) { sb.Append($"{i}"); sb.Append(' '); }
            Console.WriteLine(sb);
        }
    }
}
