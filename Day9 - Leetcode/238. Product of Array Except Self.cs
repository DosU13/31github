public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        res[0] = 1;
        for(int i=1; i<nums.Length; i++){
            res[i] = res[i-1]*nums[i-1]; 
        }
        int[] res2 = new int[nums.Length];
        res2[nums.Length-1] = 1;
        for(int i=nums.Length-2; i>=0; i--){
            res2[i] = res2[i+1]*nums[i+1];
        }
        for(int i=0; i<res.Length; i++){
            res[i] *= res2[i];
        }
        return res;
    }
}