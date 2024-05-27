using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 등수_매기기
{
    public class Solution
    {
        public int[] solution(int[,] score)
        {
            int[] answer = new int[] { };

            float[] result = new float[score.GetLength(0)];
            for (int i = 0; i < score.GetLength(0); i++)
            {
                result[i] = (float)(score[i, 0] + score[i, 1]) / 2;
            }
            answer = result.Select(x => result.Where(y => y > x).Count() + 1).ToArray();

            return answer;
        }
    }
}
