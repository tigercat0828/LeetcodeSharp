using LeetcodeSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class P94_Binary_Tree_Inorder_Traversal {

        // iterative 
        public IList<int> InorderTraversal(TreeNode root) {
            if (root == null) {
                return new List<int>();
            }
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            LeftMost(root, stack);
            while (stack.Count > 0) {
                TreeNode current = stack.Pop();
                result.Add(current.val);
                LeftMost(current.right, stack);
            }
            return result;
        }
        private void LeftMost(TreeNode root, Stack<TreeNode> stack) {
            if (root != null) {
                TreeNode current = root;
                while (current != null) {
                    stack.Push(current);
                    current = current.left;
                }
            }
        }

        public IList<int> InorderTraversal2(TreeNode root) {
            List<int> list = new List<int>();
            InOrder(root, list);
            return list;
        }
        public void InOrder(TreeNode root, List<int> list) {
            if (root != null) {
                InOrder(root.left, list);
                list.Add(root.val);
                InOrder(root.right, list);
            }
        }
    }
}
