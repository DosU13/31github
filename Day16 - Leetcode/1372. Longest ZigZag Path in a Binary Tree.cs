/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int res = 1;
    public int LongestZigZag(TreeNode root) {
        dfs(root.left, 2, false);
        dfs(root.right, 2, true);
        return res - 1;
    }

    private void dfs(TreeNode root, int run, bool isRight){
        if(root == null) return;
        if(isRight){
            dfs(root.left, run+1, false);
            dfs(root.right, 2, true);
        }else{
            dfs(root.left, 2, false);
            dfs(root.right, run+1, true);
        }
        if(res < run) res = run;
    }
}