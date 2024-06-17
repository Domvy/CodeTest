using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze
{
    internal class 크로아티아_알파벳
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] alp = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            for (int i = 0; i < alp.Length; i++)
            {
                while (s.Contains(alp[i]))
                {
                    s = s.Replace(alp[i], "A");                    
                }
            }
            Console.WriteLine(s.Length);
        }
    }
}
