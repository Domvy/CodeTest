using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 단어_공부
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToUpper();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char[] array = s.Distinct().ToArray();
            int n = 0;
            string result;
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    dic[s[i]] += 1;
                else
                    dic.Add(s[i], 1);
            }
            dic = dic.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            result = $"{dic.Last().Key}";
            foreach (KeyValuePair<char, int> d in dic)
            {
                n += d.Value == dic.Values.Max() ? 1 : 0;
                if (1 < n)
                {
                    result = "?";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
