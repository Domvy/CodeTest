using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 진료순서_정하기
{
    public class Solution
    {
        public int[] solution(int[] emergency)
        {
            int[] answer = new int[] { };            
            
            answer = new int[emergency.Length];
            int n = 1;
            while (n <= emergency.Length) 
            {
                for (int i = 0; i < emergency.Length; i++)
                {
                    if (emergency[i].Equals(emergency.Max()))
                    {
                        emergency[i] = 0;
                        answer[i] = n;
                        n++;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
