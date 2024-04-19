using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 옷가게_할인_받기
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int price = 150000;            
            Console.WriteLine(solution.solution(price));
        }
    }
    public class Solution
    {
        public int solution(int price)
        {            
            float discount =0f;
            discount = price >= 500000 ? 0.2f : price >= 300000 ? 0.1f : price >= 100000 ? 0.05f : 0;
            return (int)(price - (price * discount));
        }
    }
}
