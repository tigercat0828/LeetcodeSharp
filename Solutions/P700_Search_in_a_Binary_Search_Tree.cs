using LeetcodeSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class P700_Search_in_a_Binary_Search_Tree {

        // iterative
        public TreeNode SearchBST(TreeNode root, int val) {
            if (root == null) return null;
            TreeNode current = root;
            while (current != null) {
                if (val > current.val) {
                    current = current.right;
                    continue;
                }
                if (val < current.val) {
                    current = current.left;
                    continue;
                }
                if (current.val == val) {
                    return current;
                }
            }
            return current;
        }
        // recursive
        public TreeNode SearchBST2(TreeNode root, int val) {
            if (root == null) {
                return null;
            }
            if (val == root.val) {
                return root;
            }
            if (val > root.val) {
                return SearchBST(root.right, val);
            }
            if (val < root.val) {
                return SearchBST(root.left, val);
            }
            return null;
        }
    }
}
