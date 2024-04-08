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
        int[] numbers = { 34, 5, 71, 29, 100, 34 };
        int n = 123;
        Console.WriteLine(solution.solution(numbers, n));
    }
}
public class Solution
{
    public int solution(int[] numbers, int n)
    {
        int answer = 0;

        int i = 0;
        while (answer <= n) 
        {
            answer += numbers[i++];
        }

        return answer;
    }
}

