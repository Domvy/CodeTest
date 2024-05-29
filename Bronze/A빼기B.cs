using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace A빼기B
{
    public class A빼기B
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
        }
    }
}