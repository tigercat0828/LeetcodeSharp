namespace Leetcode.CSharp.Solutions {
    public class P328_Odd_Even_Linked_List {

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode OddEvenList(ListNode head) {
            if (head == null || head.next == null || head.next == null) {
                return null;
            }
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenhead = head.next;
            while (odd.next != null && even.next != null) {
                odd.next = even.next;
                odd = odd.next;

                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenhead;
            return head;
        }
        public ListNode OddEvenList2(ListNode head) {
            if (head == null) return null;

            ListNode last = head;
            int nodeCount = 0;
            while (last.next != null) {
                last = last.next;
                nodeCount++;
            }

            ListNode dummy = new ListNode(0, head);
            head = dummy;
            ListNode previous = head;
            ListNode current = head.next;

            int count = 0;
            while (count != nodeCount) {
                if (count % 2 == 1) {
                    last.next = new ListNode(current.val, null);
                    last = last.next;
                    previous.next = current.next;
                    current = current.next;
                }
                else {
                    previous = current;
                    current = current.next;
                }
                count++;
            }
            head = head.next;
            return head;
        }
    }
}
