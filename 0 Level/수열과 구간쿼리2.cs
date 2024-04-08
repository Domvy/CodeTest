using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace level0o
{
    public class querry2
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] arr = { 0, 1, 2, 3, 4 };
            int[,] queries = { { 0, 3 }, { 1, 2 }, { 1, 4 } };
            Console.WriteLine(solution.solution(arr, queries));
        }
    }

    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {
            int[] answer = new int[] { };
            int change;

            for (int i = 0; i < queries.Length / 2; i++)
            {
                change = arr[queries[i, 0]];
                arr[queries[i, 0]] = arr[queries[i, 1]];
                arr[queries[i, 1]] = change;
            }

            answer = arr;
            return answer;

        }
    }
}


