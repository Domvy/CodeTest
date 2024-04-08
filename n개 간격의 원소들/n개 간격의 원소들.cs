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
        int[] num_list = { 4, 2, 6, 1, 7, 6 };
        int n = 2;
        Console.WriteLine(solution.solution(num_list, n));
    }
}
public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int[] answer = new int[] { };

        answer = num_list.Where((x,Index) => Index % n == 0).ToArray();

        return answer;
    }
}
