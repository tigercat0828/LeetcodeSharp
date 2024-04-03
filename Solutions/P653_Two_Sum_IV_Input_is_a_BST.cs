using LeetcodeSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class P653_Two_Sum_IV_Input_is_a_BST {
        public bool FindTarget(TreeNode root, int k) {
            if (root == null) return false;
            Dictionary<int, TreeNode> dict = new Dictionary<int, TreeNode>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode pop = stack.Pop();
                if (dict.ContainsKey(pop.val)) {
                    return true;
                }
                else {
                    dict.Add(k - pop.val, pop);
                }
                if (pop.left != null) {
                    stack.Push(pop.left);
                }
                if (pop.right != null) {
                    stack.Push(pop.right);
                }
            }
            return false;
        }
    }
}
