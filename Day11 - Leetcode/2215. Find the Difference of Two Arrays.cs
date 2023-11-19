public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        var res = new List<IList<int>>
        {
            set1.Where(x => !set2.Contains(x)).ToList(),
            set2.Where(x => !set1.Contains(x)).ToList()
        };
        return res;
    }
}