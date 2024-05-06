using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 소인수분해
{
    public class Solution
    {
        public int[] solution(int n)
        {
            int[] answer = new int[] { };

            int num = 2;
            List<int> list = new List<int>();
            while (num <= n)
            {
                if (n % num == 0)
                {
                    if(!list.Contains(num)) list.Add(num);
                    n = n / num;
                }
                else
                    num++;
            }

            return list.ToArray();
        }
    }
}
