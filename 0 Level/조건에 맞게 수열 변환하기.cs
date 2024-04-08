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
        int[] arr = { 1, 2, 3, 100, 99, 98 };
        int k = 3;
        Console.WriteLine(solution.solution(arr, k));
    }
}
public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        int[] answer = new int[] { };
        int[] answerArray = arr;
        for (int i = 0; i < answerArray.Length; i++)
        {
            if (k % 2 != 0)
            {
                answerArray[i] = arr[i] * k;
            }
            else
                answerArray[i] = arr[i] + k;
        }
        answer = answerArray;

        return answer;
    }
}
