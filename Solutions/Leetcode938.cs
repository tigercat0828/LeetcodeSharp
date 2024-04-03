namespace LeetcodeSharp.Solutions;
public class Leetcode938
{
    int low = -1;
    int high = -1;
    int sum = 0;
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        this.low = low;
        this.high = high;
        //Inorder(root);
        sum = Traversal(root);
        return sum;
    }
    private int Traversal(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        // prune
        if (root.val > high)
        {
            return Traversal(root.left);
        }
        if (root.val < low)
        {
            return Traversal(root.right);
        }
        return root.val + Traversal(root.left) + Traversal(root.right);
    }
    private void Inorder(TreeNode node)
    {

        if (node.left != null)
        {
            Inorder(node.left);
        }
        if (low <= node.val && node.val <= high)
        {
            sum += node.val;
        }
        if (node.right != null)
        {
            Inorder(node.right);
        }
    }

}
