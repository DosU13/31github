
public class Solution
{
    private int res = 0;
    public int GoodNodes(TreeNode root)
    {
        dfs(root, root.val);
        return res;
    }

    private void dfs(TreeNode root, int max)
    {
        if(root == null) return;
        if (root.val >= max)
        {
            res++;
        }
        int newMax = Math.Max(max, root.val);
        dfs(root.left, newMax);
        dfs(root.right, newMax);
    }
}