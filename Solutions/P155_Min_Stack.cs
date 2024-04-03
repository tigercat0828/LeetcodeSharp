namespace Leetcode.CSharp.Solutions {
    public class P155_Min_Stack {
        struct Node {
            public int val;
            public int min;
            public Node(int v, int m) {
                val = v;
                min = m;
            }
        }
        List<Node> stack;
        public P155_Min_Stack() {
            stack = new List<Node>();
        }

        public void Push(int val) {
            if (stack.Count == 0) {
                stack.Add(new Node(val, val));
                return;
            }
            Node top = stack.Last();
            Node newNode = new Node(val, top.min);
            if (val < top.min) {
                newNode.min = val;
            }
            stack.Add(newNode);
        }

        public void Pop() {
            stack.RemoveAt(stack.Count - 1);
        }

        public int Top() {
            return stack.Last().val;
        }

        public int GetMin() {
            return stack.Last().min;
        }
    }
}
