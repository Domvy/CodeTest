using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 두_수의_합
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string a = "18446744073709551615";
            string b = "287346502836570928366";
            Console.WriteLine(solution.solution(a, b));
        }
    }
    public class Solution
    {
        public string solution(string a, string b)
        {
            string result = "";
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }
                carry = sum / 10;
                int digit = sum % 10;
                result = digit.ToString() + result;
            }
            return result;
        }
    }
}
