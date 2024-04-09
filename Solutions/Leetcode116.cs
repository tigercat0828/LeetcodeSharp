namespace LeetcodeSharp.Solutions;

public class Leetcode116 {

    // recursive
    public Node Connect(Node root) {
        if (root != null) {
            if (root.left != null) {
                root.left.next = root.right;
            }
            if (root.right != null && root.next != null) {
                root.right.next = root.next.left;
            }
            Connect(root.left);
            Connect(root.right);
        }
        return root;
    }
    // iterative
    // Time O(n) levelOrder Traversal
    // Space O(n)
    public Node Connect2(Node root) {
        if (root == null) return null;
        List<List<Node>> levelList = [];
        Queue<Node> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int size = queue.Count;
            List<Node> list = new();
            for (int i = 0; i < size; i++) {
                Node pop = queue.Dequeue();
                list.Add(pop);
                if (pop.left != null) {
                    queue.Enqueue(pop.left);
                }
                if (pop.right != null) {
                    queue.Enqueue(pop.right);
                }
            }
            levelList.Add(list);
        }
        foreach (var level in levelList) {
            for (int i = 0; i < level.Count - 1; i++) {
                level[i].next = level[i + 1];
            }
        }
        return root;
    }
    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int val) {
            this.val = val;
        }

        public Node(int val, Node _left, Node _right, Node _next) {
            this.val = val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
