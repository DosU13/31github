public class Solution
{
    List<int> res = new List<int>();
    public IList<int> RightSideView(TreeNode root)
    {
        dfs(root, 0);
        return res;
    }

    private void dfs(TreeNode root, int lvl)
    {
        if (root == null) return;
        if(res.Count <= lvl) res.Add(root.val);
        else res[lvl] = root.val;
        dfs(root.left, lvl + 1);
        dfs(root.right, lvl+1);
    }
}