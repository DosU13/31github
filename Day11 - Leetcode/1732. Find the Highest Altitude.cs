public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        for(int i = 1; i < gain.Length; i++)
        {
            gain[i] += gain[i - 1];
        }
        return Math.Max(0, gain.Max());
    }
}