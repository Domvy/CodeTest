using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가까운_수
{
    public class Solution
    {
        public int solution(int[] array, int n)
        {
            int answer = array[0];
            
            foreach (int i in array)
            {
                if (Math.Abs(answer - n) > Math.Abs(i - n))
                {
                    answer = i;
                }  
                else if(Math.Abs(answer - n) == Math.Abs(i - n))
                {
                    answer = answer < i ? answer : i;
                }
            }

            return answer;
        }
    }
}
