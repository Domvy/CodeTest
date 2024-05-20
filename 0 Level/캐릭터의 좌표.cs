using System;
using System.Collections.Generic;
using System.Linq;

namespace 캐릭터의_좌표
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] keyinput = { "down", "down", "down", "down", "down" };
            int[] board = { 7, 9 };
            Console.WriteLine(solution.solution(keyinput, board));
        }
    }
    public class Solution
    {
        public int[] solution(string[] keyinput, int[] board)
        {
            int[] answer = new int[] { };

            answer = new int[] { 0, 0 };
            int maximumX = board[0] % 2 == 0 ? board[0] / 2 : (board[0] + 1) / 2 - 1;
            int maximumY = board[1] % 2 == 0 ? board[1] / 2 : (board[1] + 1) / 2 - 1;
            for (int i = 0; i < keyinput.Length; i++)
            {
                switch (keyinput[i])
                {
                    case "up":
                        if (answer[1] < maximumY)
                            answer[1] += 1;
                        break;
                    case "down":
                        if (answer[1] > -maximumY)
                            answer[1] -= 1;
                        break;
                    case "right":
                        if (answer[0] < maximumX)
                            answer[0] += 1;
                        break;
                    case "left":
                        if (answer[0] > -maximumX)
                            answer[0] -= 1;
                        break;
                }
            }


            return answer;
        }
    }
}
