using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열_원소의_길이
{
    public class Solution
    {
        public int[] solution(string[] strlist)
        {
            int[] answer = new int[] { };

            answer = strlist.Select(x => x.Length).ToArray();

            return answer;
        }
    }
}
