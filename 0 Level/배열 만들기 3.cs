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
        int[] arr = { 1, 2, 3, 4, 5 };
        int[,] intervals = { { 1, 3 }, { 0, 4 } };
        Console.WriteLine(solution.solution(arr, intervals));
    }
}
public class Solution
{
    public int[] solution(int[] arr, int[,] intervals)
    {
        int[] answer = new int[] { };

        List<int> list = new List<int>();
        int[] arrA = arr.Skip(intervals[0, 0]).Take(intervals[0,1] + 1 - intervals[0, 0]).ToArray();
        int[] arrB = arr.Skip(intervals[1, 0]).Take(intervals[1, 1] + 1 - intervals[1, 0]).ToArray();
        list.AddRange(arrA);
        list.AddRange(arrB);
        answer = list.ToArray();

        return answer;
    }
}
