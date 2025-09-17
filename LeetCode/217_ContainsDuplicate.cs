using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _217_ContainsDuplicate
    {
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                int[] result = nums.Distinct().ToArray();

                return nums.Length == result.Length ? false : true;
            }
        }
    }
}
