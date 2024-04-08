using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        int[] arr = { 0, 1, 2, 3, 4 };
        int[,] queries = { { 0, 1 }, { 1, 2 }, { 2, 3 } };
        Console.WriteLine(solution.solution(arr, queries));
    }
}
public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = new int[] { };

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i,0];
            int e = queries[i,1];

            for (int j = 0; j < arr.Length; j++)
            {
                if (s <= j && j <= e)
                {
                    arr[j] += 1;
                }              
            }
        }
        answer = arr;

        return answer;
    }
}

