/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private TreeNode res, p, q;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        this.p = p;
        this.q = q;
        dfs(root);
        return res;
    }

    private (bool, bool) dfs(TreeNode root){
        if(root == null) return (false, false);
        var l = dfs(root.left);
        var r = dfs(root.right);
        var ret = (r.Item1||l.Item1, r.Item2||l.Item2);
        if(root == p) ret = (true, ret.Item2);
        if(root == q) ret = (ret.Item1, true);
        if(ret.Item1 && ret.Item2 && res == null) {
            res = root;
        }
        return ret;
    }
}