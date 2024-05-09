using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 숨어있는_숫자의_덧셈
{
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;

            foreach (char c in my_string)
            {
                if (48 <= (int)c && (int)c <= 57)
                    continue;
                else
                    my_string = my_string.Replace(c, ' ');
            }
            string[] stringArray = new string[] { };
            stringArray = my_string.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (stringArray.Length > 0)
                answer = stringArray.Select(x => int.Parse(x)).Aggregate((x, y) => x + y);


            return answer;
        }
    }
}
