using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Level
{
    internal class 가장_많이_받은_선물
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string[] friends = { "muzi", "ryan", "frodo", "neo" };
            string[] gifts = { "muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi"
                    , "ryan muzi", "frodo muzi", "frodo ryan", "neo muzi" };
            sol.solution(friends, gifts);
        }
        public class Solution
        {
            public int solution(string[] friends, string[] gifts)
            {
                int answer = 0;

                Dictionary<string, int> scores = new Dictionary<string, int>();
                int[] takes = new int[friends.Length];
                int[,] giveAndTakes = new int[friends.Length, friends.Length];
                foreach (string friend in friends) { scores.Add(friend, 0); }
                for (int i = 0; i < gifts.Length; i++)
                {
                    int a = 0;
                    int b = 0;
                    string[] gt = gifts[i].Split();
                    for (int j = 0; j < friends.Length; j++)
                    {
                        if (gt[0] == friends[j])
                        {
                            a = j;
                            scores[gt[0]]++;
                        }
                        if (gt[1] == friends[j])
                        {
                            b = j;
                            scores[gt[1]]--;
                        }
                    }
                    giveAndTakes[a, b]++;
                }
                for (int i = 0; i < friends.Length; i++)
                {
                    for (int j = 0; j < friends.Length; j++)
                    {
                        if (giveAndTakes[i, j] > giveAndTakes[j, i])
                        {
                            takes[i]++;
                        }
                        else if (giveAndTakes[i, j] == giveAndTakes[j, i])
                        {
                            if (scores[friends[i]] > scores[friends[j]])
                            {
                                takes[i]++;
                            }
                        }
                        else
                            continue;
                    }
                }
                answer = takes.Max();

                return answer;
            }
        }
    }
}
