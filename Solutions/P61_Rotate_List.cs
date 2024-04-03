namespace Leetcode.CSharp.Solutions {
    public class P61_Rotate_List {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode RotateRight(ListNode head, int k) {
            if (head == null) {      // zero node
                return null;
            }
            if (head.next == null) { // one node
                return head;
            }

            int count = 1;
            ListNode tail = head;
            while (tail.next != null) {
                count++;
                tail = tail.next;
            }
            k = k % count;
            if (k == 0) return head;
            // make ring
            tail.next = head;

            // shift head
            ListNode current = head;    // new head
            ListNode previous = null;
            int move = count - k;
            for (int i = 0; i < move; i++) {
                previous = current;
                current = current.next;
            }
            previous.next = null;       // cut the ring
            return current;
        }
    }
}
