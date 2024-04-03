using LeetcodeSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class P876_Middle_of_the_Linked_List {
        // O(n/2) by fast and slow pointer
        public ListNode MiddleNode(ListNode head) {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null && slow != null) {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }

        // O(n) traversal until the end
        public ListNode MiddleNode2(ListNode head) {
            int count = 0;
            ListNode current = head;
            while (current != null) {
                current = current.next;
                count++;
            }
            int move = count / 2;

            current = head;
            for (int i = 0; i < move; i++) {
                current = current.next;
            }
            return current;
        }
    }
}
