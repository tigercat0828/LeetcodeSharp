using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P226_Invert_Binary_Tree {

        public TreeNode InvertTree(TreeNode root) {
            if (root != null) {
                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;

                InvertTree(root.left);
                InvertTree(root.right);
            }
            return root;
        }
    }
}
