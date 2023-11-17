public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int requirement = candies.Max() - extraCandies;
        return candies.Select(x => x >= requirement).ToList();
    }
}