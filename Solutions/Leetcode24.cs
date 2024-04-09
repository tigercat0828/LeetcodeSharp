using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions; 
public class Leetcode24 {

    // iterative
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        ListNode dummy = new(0, head);
        ListNode current = dummy;
        while (current.next != null && current.next.next != null) {
            ListNode A = current.next;
            ListNode B = current.next.next;
            current.next = B;
            A.next = B.next;
            B.next = A;
            current = current.next.next;
        }
        return dummy.next;
    }
    // recursive
    public ListNode SwapPairs2(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        ListNode A = head;
        ListNode B = head.next;

        A.next = SwapPairs(B.next);
        B.next = A;
        return B;
    }
}
