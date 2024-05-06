using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 구슬을_나누는_경우의_수
{    
    public class Solution
    {
        public double solution(int balls, int share)
        {         
            
            return Math.Round(Factorial(balls) / (Factorial(balls - share) * Factorial(share)));
        }
        public double Factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }
    }

}
