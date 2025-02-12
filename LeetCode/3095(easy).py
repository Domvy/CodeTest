class Solution(object):
    def minimumSubarrayLength(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: int
        """
        minimum = float('inf')
        for i in range(len(nums)):
            s = 0
            for j in range(i, len(nums)):
                s |= nums[j]
                if s >= k:
                    minimum = min(minimum, j - i + 1)
                    
        return -1 if minimum == float('inf') else minimum 