using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7의_개수
{
    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;

            for (int num = 0; num < array.Length; num++) 
            {
                do
                {
                    answer += array[num] % 10 == 7 ? 1 : 0;
                    array[num] /= 10;
                }while (array[num] > 0);
            }
            

            return answer;
        }
    }
}
