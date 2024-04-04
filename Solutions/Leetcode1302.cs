using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;

// O(n) node of the root, BFS
public class Leetcode1302 {
    public int DeepestLeavesSum(TreeNode root) {

        if (root == null) return 0;

        int sum = 0;
        Queue<TreeNode> queue = [];
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int size = queue.Count;
            sum = 0;
            for (int i = 0; i < size; i++) {
                TreeNode pop = queue.Dequeue();
                sum += pop.val;

                if (pop.left != null) {
                    queue.Enqueue(pop.left);
                }
                if (pop.right != null) {
                    queue.Enqueue(pop.right);
                }
            }

        }
        return sum;
    }
}
