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
        int[] num_list = { 12, 4, 15, 46, 38, 1, 14 };
        Console.WriteLine(solution.solution(num_list));              
    }
}
public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[] { };

        var answerArray = from n in num_list
                          orderby n ascending
                          select n;
        answer = answerArray.Take(5).ToArray();
        return answer;
    }
}
