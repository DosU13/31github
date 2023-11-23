
public class Solution
{
    int res = 0;
    List<int> list = new List<int>();
    public int PathSum(TreeNode root, int targetSum)
    {
        dfs(root, targetSum);
        return res;
    }

    private void dfs(TreeNode root, int targetSum)
    {
        if (root == null) return;
        list.Add(root.val);
        CheckList(targetSum);
        dfs(root.left, targetSum);
        dfs(root.right, targetSum);
        list.RemoveAt(list.Count-1);
    }

    private void CheckList(int targetSum)
    {
        long sum = 0;
        for (int i = list.Count-1;  i >= 0; i--)
        {
            sum += list[i];
            if (sum == targetSum)
            {
                res++;
            }
        }
    }
}