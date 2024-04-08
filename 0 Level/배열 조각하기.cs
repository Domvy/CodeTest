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
        int[] arr = { 0, 1, 2, 3, 4, 5 };
        int[] query = { 4, 1, 2 };
        Console.WriteLine(solution.solution(arr, query));
    }
}
public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        int[] answer = new int[] { };

        for (int i = 0; i < query.Length; i++)
        {
            if (i % 2 == 0)
            {
                arr = arr.Where((x,Index) => Index <= query[i]).ToArray();
            }
            else
            {
                arr = arr.Where((x, Index) => Index >= query[i]).ToArray();
            }
        }
        answer = arr;
        return answer;
    }
}
