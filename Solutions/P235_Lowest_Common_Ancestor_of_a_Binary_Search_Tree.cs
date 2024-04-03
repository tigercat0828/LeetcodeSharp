using LeetcodeSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class P235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree {
        // traversal until go different path
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root == null) return null;
            TreeNode ancestor = root;
            TreeNode currentP = root;
            TreeNode currentQ = root;
            while (currentQ != null && currentP != null) {
                // find P
                ancestor = currentP;
                if (p.val < currentP.val) {
                    currentP = currentP.left;
                }
                else if (p.val > currentP.val) {
                    currentP = currentP.right;
                }
                else {
                    return currentP;
                }
                // find Q
                ancestor = currentQ;
                if (q.val < currentQ.val) {
                    currentQ = currentQ.left;
                }
                else if (q.val > currentQ.val) {
                    currentQ = currentQ.right;
                }
                else {
                    return currentQ;
                }
                if (currentP.val != currentQ.val) {
                    return ancestor;
                }
            }
            return null;
        }
    }
}
