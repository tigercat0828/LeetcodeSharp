using LeetcodeSharp.Common;

namespace Leetcode.CSharp.Solutions;
public class Leetcode1457 {
    int palindromicPaths = 0;

    public int PseudoPalindromicPaths(TreeNode root) {
        // bit multiplation
        Stack<(TreeNode, int)> stack = [];
        int palinedrome = 0;
        stack.Push((root, 0));
        while (stack.Count > 0) {

            var (node, path) = stack.Pop();
            if (node == null) continue;


            path ^= (1 << node.val);        // record the val frequency
            if (node.left == null && node.right == null) {
                if ((path & (path - 1)) == 0)    // check if there is at most one element
                    palinedrome++;
            }
            else {
                stack.Push((node.left, path));
                stack.Push((node.right, path));
            }
        }
        return palinedrome;
    }


    public int PseudoPalindromicPaths2(TreeNode root) {
        palindromicPaths = 0;
        Traversal(root, []);
        return palindromicPaths;
    }
    private void Traversal(TreeNode node, HashSet<int> digits) {
        if (node == null) return;

        int val = node.val;

        if (!digits.Add(val)) {
            digits.Remove(val);
        }

        if (node.left == null && node.right == null) {
            if (digits.Count < 2) palindromicPaths++;
        }
        else {
            Traversal(node.left, digits);
            Traversal(node.right, digits);
        }

        if (!digits.Remove(val)) {
            digits.Add(val);
        }
    }
}