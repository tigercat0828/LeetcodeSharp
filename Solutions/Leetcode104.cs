using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode104 {

    int maxHeight = 0;
    // iterative (BFS)
    public int MaxDepth3(TreeNode root) {
        if (root == null) return 0;

        Queue<TreeNode> queue = [];
        List<List<int>> listList = [];
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int size = queue.Count;
            List<int> list = [];
            for (int i = 0; i < size; i++) {
                TreeNode node = queue.Dequeue();
                list.Add(node.val);
                if (node.left != null) {
                    queue.Enqueue(node.left);
                }
                if (node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            listList.Add(list);
        }
        return listList.Count;
    }

    // top-down
    public int MaxDepth2(TreeNode root) {
        Height(root, 0);
        return maxHeight;
    }
    private void Height(TreeNode root, int depth) {
        if (root == null) return;
        // update answer
        if (root.left == null && root.left == null) {
            maxHeight = Math.Max(maxHeight, depth + 1);
        }
        Height(root.left, depth + 1);
        Height(root.right, depth + 1);
    }
    // bottom-up
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        if (root.right == null && root.left == null) {
            return 1;
        }
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;

    }
}
