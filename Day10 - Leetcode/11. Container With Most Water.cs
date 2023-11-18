public class Solution
{
    public int MaxArea(int[] height)
    {
        int l = 0, r = height.Length - 1, res = 0;
        res = Math.Min(height[l], height[r])*(r-l);
        while (l < r)
        {
            if (height[l] <= height[r])
            {
                for (int i = l + 1;; i++)
                {
                    if (height[i] > height[l] || i==r)
                    {
                        l = i;
                        res = Math.Max(res, Math.Min(height[l], height[r]) * (r - l));
                        break;
                    }
                }
            }
            else
            {
                for (int i = r - 1;; i--)
                {
                    if (height[i] > height[r])
                    {
                        r = i;
                        res = Math.Max(res, Math.Min(height[l], height[r]) * (r - l));
                        break;
                    }
                }
            }
        }
        return res;
    }
}