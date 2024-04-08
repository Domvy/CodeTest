// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;


namespace level0g
{
    public class CodeTest
    {
        public static void Main()
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();

            string a = null;
            foreach (char c in s)
            {
                a += Char.IsUpper(c) ? Char.ToLower(c) : Char.ToUpper(c);
            }
            Console.WriteLine(a);
        }
    }
}
