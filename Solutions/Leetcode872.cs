using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class Leetcode872 {
        public bool LeafSimilar(TreeNode root1, TreeNode root2) {

            List<int> leaves1 = [];
            List<int> leaves2 = [];
            Traversal(root1, leaves1);
            Traversal(root2, leaves2);
            if (leaves1.Count != leaves2.Count) return false;
            for (int i = 0; i < leaves1.Count; i++) {
                if (leaves1[i] != leaves2[i]) return false;
            }
            return true;
        }
        public void Traversal(TreeNode root, List<int> leaves) {
            if (root == null) return;
            if (root.left == null && root.right == null) leaves.Add(root.val);
            Traversal(root.left, leaves);
            Traversal(root.right, leaves);
        }
    }
}
