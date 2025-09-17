using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _88_MergeSortedArray
    {
        public class Solution
        {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int temp = 0;
                for (int i = 0; i < n; i++)
                {
                    nums1[i + m] = nums2[i];
                }
                Array.Sort(nums1);               
            }
        }
    }
}
