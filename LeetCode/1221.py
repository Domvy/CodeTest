class Solution(object):
    def balancedStringSplit(self, s):
        """
        :type s: str
        :rtype: int
        """
        b = 0
        cnt = 0
        for i in range(len(s)):
            b += 1 if s[i] == 'R' else -1
            if b == 0:                
                cnt += 1

        return cnt