public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int maxOnes = 0, maxDoubleOnes = 0, previousOnes = 0, cnt = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if (nums[i] == 1) cnt++;
            else
            {
                if (cnt == 0) previousOnes = int.MinValue;
                else
                {
                    maxOnes = Math.Max(maxOnes, cnt);
                    maxDoubleOnes = Math.Max(maxDoubleOnes, previousOnes + cnt);
                    previousOnes = cnt;
                    cnt = 0;
                }
            }
        }
        if (cnt != 0)
        {
            maxOnes = Math.Max(maxOnes, cnt);
            maxDoubleOnes = Math.Max(maxDoubleOnes, previousOnes + cnt);
        }
        int res = Math.Max(maxDoubleOnes, maxOnes);
        if (!nums.Contains(0)) res--;
        return res;
    }
}