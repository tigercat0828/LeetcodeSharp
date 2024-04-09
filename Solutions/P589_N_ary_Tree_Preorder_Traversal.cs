namespace LeetcodeSharp.Solutions {
    public class P589_N_ary_Tree_Preorder_Traversal {
        public class Node {
            public int val;
            public IList<Node> children;
            public Node() { }
            public Node(int _val) {
                val = _val;
            }
            public Node(int _val, IList<Node> _children) {
                val = _val;
                children = _children;
            }
        }
        public IList<int> Preorder2(Node root) {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0) {
                Node pop = stack.Pop();
                list.Add(pop.val);
                foreach (var node in pop.children.Reverse()) {
                    stack.Push(node);
                }
            }
            return list;
        }
        public IList<int> Preorder(Node root) {
            List<int> result = new List<int>();
            preorder(root, result);
            return result;
        }
        public void preorder(Node root, List<int> list) {
            if (root != null) {
                list.Add(root.val);
                foreach (var node in root.children) {
                    preorder(node, list);
                }
            }
        }
    }
}
