using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P145_Binary_Tree_Postorder_Traversal {
        // iterative
        public IList<int> PostorderTraversal(TreeNode root) {
            if (root == null) {
                return new List<int>();
            }
            List<int> result = new();
            Stack<TreeNode> stack = new();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                result.Add(node.val);
                if (node.left != null) {
                    stack.Push(node.left);
                }
                if (node.right != null) {
                    stack.Push(node.right);
                }
            }
            result.Reverse();
            return result;
        }
        // recursion
        public IList<int> PostorderTraversal2(TreeNode root) {
            List<int> result = new();
            PostOrder(root, result);
            return result;
        }

        private void PostOrder(TreeNode root, List<int> result) {
            if (root != null) {
                PostOrder(root.left, result);
                PostOrder(root.right, result);
                result.Add(root.val);
            }
        }
    }
}
