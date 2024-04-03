namespace Leetcode.CSharp.Solutions {
    public class P234_Palindrome_Linked_List {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }
        // space O(1), time O(n)
        public bool IsPalindrome(ListNode head) {

            // reverse the second half of the list
            if (head == null) return false;
            if (head.next == null) return true;
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null) {
                fast = fast.next.next;
                slow = slow.next;
            }
            ListNode rear = Reverse(slow);
            ListNode front = head;
            while (front != null && rear != null) {
                if (front.val != rear.val) {
                    return false;
                }
                front = front.next;
                rear = rear.next;
            }
            return true;
        }

        private ListNode Reverse(ListNode slow) {
            ListNode previous = null;
            ListNode current = slow;
            ListNode future = null;
            while (current != null) {
                future = current.next;
                current.next = previous;
                previous = current;
                current = future;
            }
            return previous;
        }

    }
}
