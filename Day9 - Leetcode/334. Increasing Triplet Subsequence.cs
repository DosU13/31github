public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int a = int.MaxValue, b = int.MaxValue;
        foreach(var x in nums){
            if(x > b) return true;
            else if(x > a) b = x;
            else if(x < a) a = x;
        }
        return false;
    }
}