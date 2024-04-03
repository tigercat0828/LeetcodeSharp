namespace Leetcode.CSharp.Solutions;
public class Leetcode783 {
    int prvious = -200000;
    int min = int.MaxValue;
    public int MinDiffInBST(TreeNode root) {
        InOrder(root);
        return min;
    }
    private void InOrder(TreeNode root) {
        if (root is null) return;
        InOrder(root.left);
        min = Math.Min(min, root.val - prvious);
        prvious = root.val;
        InOrder(root.right);
    }
}
