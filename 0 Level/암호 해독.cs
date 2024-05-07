using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 암호_해독
{
    public class Solution
    {
        public string solution(string cipher, int code)
        {
            string answer = "";

            answer += string.Concat(cipher.Where((x, Index) => (Index + 1) % code == 0));

            return answer;
        }
    }
}
