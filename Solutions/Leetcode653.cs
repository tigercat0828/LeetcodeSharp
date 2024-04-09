using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions; 
public class Leetcode653 {
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) return false;
        Dictionary<int, TreeNode> dict = [];
        Stack<TreeNode> stack = new();
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
