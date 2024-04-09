namespace LeetcodeSharp.Solutions {

    public class P430_Flatten_a_Multilevel_Doubly_Linked_List {
        public class Node {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }
        public Node Flatten(Node head) {
            if (head == null) return null;

            Stack<Node> stack = new Stack<Node>();
            Node newHead = new Node();
            Node tail = newHead;

            stack.Push(head);
            while (stack.Count > 0) {
                Node pop = stack.Pop();
                if (pop != null) {
                    // add to tail
                    Node node = new Node();
                    node.val = pop.val;
                    tail.next = node;
                    node.prev = tail;
                    tail = tail.next;

                    if (pop.next != null) {
                        stack.Push(pop.next);
                    }
                    if (pop.child != null) {
                        stack.Push(pop.child);
                    }
                }
            }
            newHead = newHead.next;
            newHead.prev = null;
            return newHead;
        }
    }
}
