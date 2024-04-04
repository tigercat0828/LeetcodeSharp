using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode98 {
    public bool IsValidBST(TreeNode root) {
        return Check(root, long.MinValue, long.MaxValue);
    }
    private bool Check(TreeNode root, long min, long max) {
        if (root == null) return true;
        if (root.val <= min || root.val >= max) return false;
        bool left = Check(root.left, min, root.val);
        bool right = Check(root.right, root.val, max);
        return left && right;
    }
}
