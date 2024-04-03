using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode112 {

    public bool HasPathSum(TreeNode root, int targetSum) {
        return recursive(root, targetSum);
    }
    private bool recursive(TreeNode root, int remain) {

        if (root == null) return false;

        remain -= root.val;
        if (root.right == null && root.left == null) {
            return remain == 0;
        }
        bool left = recursive(root.left, remain);
        bool right = recursive(root.right, remain);
        return left || right;
    }

}
