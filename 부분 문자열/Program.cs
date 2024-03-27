using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.solution("tbt", "tbbttb"));
    }
}

public class Solution
{
    public int solution(string str1, string str2)
    {
        int answer = 0;
        answer = str2.Contains(str1) ? 1 : 0;

        return answer;
    }
}

