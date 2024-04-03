using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode1026 {
    int result = 0;
    public int MaxAncestorDiff(TreeNode root) {
        FindMaxDiff(root, root.val, root.val);
        return result;
    }
    private void FindMaxDiff(TreeNode node, int min, int max) {
        if (node == null) return;
        result = Max(
            result,
            Math.Abs(node.val - min),
            Math.Abs(node.val - max)
        );
        min = Math.Min(min, node.val);
        max = Math.Max(max, node.val);

        FindMaxDiff(node.left, min, max);
        FindMaxDiff(node.right, min, max);
    }
    private int Max(int A, int B, int C) {
        return Math.Max(A, Math.Max(B, C));
    }

}
