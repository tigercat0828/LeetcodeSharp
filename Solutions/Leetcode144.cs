using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions; 
public class Leetcode144 {

    // iterative
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null) {
            return [];
        }
        List<int> list = [];
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while (stack.Count > 0) {
            TreeNode node = stack.Pop();
            list.Add(node.val);
            if (node.right != null) {
                stack.Push(node.right);
            }
            if (node.left != null) {
                stack.Push(node.left);
            }
        }
        return list;
    }
    // recursion
    public IList<int> PreorderTraversal2(TreeNode root) {
        List<int> list = [];
        PreOrder(root, list);
        return list;
    }
    private void PreOrder(TreeNode root, List<int> list) {
        if (root != null) {
            list.Add(root.val);
            PreOrder(root.left, list);
            PreOrder(root.right, list);
        }
    }
}
