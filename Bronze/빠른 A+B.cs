using System;
using System.Text;

namespace Bronze
{    
    internal class 빠른_A_B
    {
        static void Main(string[] args)
        {            
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if(i != 0) sb.AppendLine();
                sb.Append(Console.ReadLine().Split(' ').Select(int.Parse).Aggregate((x, y) => x + y));
                
            }
            Console.WriteLine(sb);
        }
    }
}
