namespace LeetcodeSharp.Solutions;
public class Leetcode138 {
    public class Node(int _val) {
        public int val = _val;
        public Node next = null!;
        public Node random = null!;
    }
    public Node CopyRandomList(Node head) {
        if (head == null) return null!;
        Dictionary<Node, Node> map = [];

        // copy node in list
        Node current = head;
        while (current != null) {
            map.Add(current, new Node(current.val));
            current = current.next;
        }
        // connect nodes' next and random
        current = head;
        while (current != null) {
            if (current.next != null) {
                map[current].next = map[current.next];
            }
            if (current.random != null) {
                map[current].random = map[current.random];
            }
            current = current.next!;
        }
        return map[head];
    }
}
