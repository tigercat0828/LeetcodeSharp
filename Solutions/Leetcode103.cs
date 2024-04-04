using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode103 {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if (root == null) {
            return [];
        }
        List<IList<int>> listList = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        bool reverse = false;
        while (queue.Count > 0) {
            List<int> list = [];
            int size = queue.Count;
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
            reverse = !reverse;
            if (reverse) {
                list.Reverse();
            }
            listList.Add(list);
        }
        return listList;
    }
}
