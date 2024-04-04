using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;

public class Leetcode2265 {
    public struct NodeInfo {
        public int sum;
        public int count;
        public NodeInfo() {
            sum = 0;
            count = 0;
        }
        public NodeInfo(NodeInfo other) : this(other.sum, other.count) { }
        public NodeInfo(int sum, int count) {
            this.sum = sum;
            this.count = count;
        }
        public static NodeInfo operator +(NodeInfo a, NodeInfo b) {
            return new NodeInfo(a.sum + b.sum, a.count + b.count);
        }
    }
    int answer = 0;
    public int AverageOfSubtree(TreeNode root) {
        Traversal(root);
        return answer;
    }
    private NodeInfo Traversal(TreeNode root) {
        NodeInfo current = new(root.val, 1);
        if (root.left != null) {
            current += Traversal(root.left);
        }
        if (root.right != null) {
            current += Traversal(root.right);
        }
        if (root.val == current.sum / current.count) // average
            answer++;
        return new(current);
    }
}