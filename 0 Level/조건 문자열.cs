using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class 조건_문자열
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.solution("<", "=", 20, 50));
    }}

public class Solution
{
    public int solution(string ineq, string eq, int n, int m)
    {
        int answer = 0;
        bool a;
        if (eq == "=")
        {
            a = ineq == "<" ? n <= m : n >= m;
        }
        else
        {
            a = ineq == "<" ? n < m : n > m;
        }
        answer = a ? 1 : 0;

        return answer;
    }
}

