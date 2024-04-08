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
        string[] todo_list = { "problemsolving", "practiceguitar", "swim", "studygraph" };
        bool[] finished = { true, false, true, false };
        Console.WriteLine(solution.solution(todo_list, finished));
    }
}
public class Solution
{
    public string[] solution(string[] todo_list, bool[] finished)
    {
        string[] answer = new string[] { };

        List<string> list = new List<string>(); 
        for (int i = 0; i < todo_list.Length; i++)
        {
            if (!finished[i])
            {
                list.Add(todo_list[i]);
            }
        }
        answer = list.ToArray();  

        return answer;
    }
}
