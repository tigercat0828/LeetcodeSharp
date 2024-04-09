namespace LeetcodeSharp.Solutions {
    public class Leetcode117 {
        public class Node {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val) {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next) {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        public Node Connect(Node root) {
            if (root == null) return null;
            List<List<Node>> levelList = [];
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            // level order traversal
            while (queue.Count > 0) {
                List<Node> list = [];
                int size = queue.Count;
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
            // Debug
            foreach (var level in levelList) {
                foreach (var node in level) {
                    Console.Write(node.val + ",");
                }
                Console.WriteLine();
            }
            // connect same level node
            foreach (List<Node> level in levelList) {
                for (int i = 0; i < level.Count - 1; i++) {
                    level[i].next = level[i + 1];
                }
            }

            return root;
        }
    }
}
