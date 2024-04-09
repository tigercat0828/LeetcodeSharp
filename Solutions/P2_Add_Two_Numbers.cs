using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P2_Add_Two_Numbers {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            // dummy node
            ListNode head = new ListNode(0);
            ListNode tail = head;

            // l1 + l2
            while (l1 != null && l2 != null) {
                tail.next = new ListNode(l1.val + l2.val, null);
                tail = tail.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            if (l1 != null) {
                tail.next = l1;
            }
            if (l2 != null) {
                tail.next = l2;
            }

            ListNode current = head;
            while (current != null) {
                if (current.val >= 10) {
                    // perform carry
                    current.val -= 10;
                    if (current.next != null) {
                        current.next.val += 1;
                    }
                    else {
                        current.next = new ListNode(1);
                    }
                }
                current = current.next;
            }
            return head.next;
        }
    }
}
