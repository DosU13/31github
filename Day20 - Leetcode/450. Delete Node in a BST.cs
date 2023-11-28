
public class Solution
{
    private TreeNode InorderSuccessor(TreeNode root)
    {
        while (root.left != null)
        {
            root = root.left;
        }
        return root;
    }

    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;
        if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        } else if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            if(root.left == null) return root.right;
            if(root.right == null) return root.left;

            var inorderSuccessor = InorderSuccessor(root.right);
            root.val = inorderSuccessor.val;
            root.right = DeleteNode(root.right, inorderSuccessor.val);
        }
        return root;
    }
}