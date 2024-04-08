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
        int[] arr = { 1, 2, 1, 4, 5, 2, 9 };
        Console.WriteLine(solution.solution(arr));
    }
}
public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] answer = new int[] { };

        if (arr.Contains(2))
        {
            answer = arr.SkipWhile(x => x != 2).ToArray();
            answer = answer.Reverse().SkipWhile(x => x !=2).Reverse().ToArray();            
        }
        else
            answer = new int[1] { -1 };


        foreach (int i in answer) { Console.WriteLine(i); }
        return answer;
    }
}
