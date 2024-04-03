using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode102 {

    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null) {
            return [];
        }
        List<IList<int>> listList = [];
        Queue<TreeNode> queue = [];

        queue.Enqueue(root);
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
            listList.Add(list);
        }
        return listList;
    }
}
