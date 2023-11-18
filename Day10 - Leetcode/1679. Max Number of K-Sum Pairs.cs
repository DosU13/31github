using System.Linq;

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int res = 0;
        foreach (var x in nums)
        {
            if (x > k) continue;
            if (counts.TryGetValue(k - x, out int value) && value > 0)
            {
                res++;
                counts[k - x]--;
            }else if(counts.ContainsKey(x))
                counts[x]++;
            else counts[x] = 1;
        }
        return res;
    }
}