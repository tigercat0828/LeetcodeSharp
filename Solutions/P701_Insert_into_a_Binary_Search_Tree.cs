using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P701_Insert_into_a_Binary_Search_Tree {
        public TreeNode InsertIntoBST(TreeNode root, int val) {
            if (root == null) {
                return new TreeNode(val);
            }
            if (val < root.val) {
                root.left = InsertIntoBST(root.left, val);
            }
            else if (val > root.val) {
                root.right = InsertIntoBST(root.right, val);
            }
            else {
                Console.WriteLine("Duplicate Value");
            }
            return root;
        }
    }
}
