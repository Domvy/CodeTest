using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _15_3Sum
    {
        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                IList<IList<int>> result = new List<IList<int>>();

                Array.Sort(nums);
                
                for (int k = 0; k < nums.Length - 2; k++)
                {
                    int left = k + 1;
                    int right = nums.Length - 1;

                    if (k > 0 && nums[k] == nums[k - 1])                    
                        continue;
                    
                    while (left < right)
                    {
                        int sum = nums[k] + nums[left] + nums[right];
                        if (sum == 0)
                        {
                            result.Add(new List<int> { nums[k], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                            left++;
                            right--;
                        }
                        if (sum < 0)
                        {
                            left++;
                        }
                        if (sum > 0)
                        {
                            right--;
                        }
                    }
                }                

                return result;
            }
        }
    }
}
