using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P404_Sum_of_Left_Leaves {
        class Node {

            public TreeNode treeNode;
            public bool isLeft;  // 0=L, 1=R
            public Node(TreeNode node, bool LR) {
                treeNode = node;
                isLeft = LR;
            }
        }
        // iterative
        public int SumOfLeftLeaves2(TreeNode root) {
            int sum = 0;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(new Node(root, false));
            while (stack.Count > 0) {
                Node node = stack.Pop();
                if (node.treeNode.left == null && node.treeNode.right == null) {
                    if (node.isLeft) {
                        sum += node.treeNode.val;
                    }
                    continue;
                }
                if (node.treeNode.left != null) {
                    stack.Push(new Node(node.treeNode.left, true));
                }
                if (node.treeNode.right != null) {
                    stack.Push(new Node(node.treeNode.right, false));
                }
            }
            return sum;
        }
        // recursive
        public int SumOfLeftLeaves(TreeNode root) {
            return helper(root, false);
        }
        private int helper(TreeNode root, bool isLeft) {
            if (root == null) return 0;
            if (isLeft && root.left == null && root.right == null) return root.val;
            return helper(root.left, true) + helper(root.right, false);
        }

    }
}
