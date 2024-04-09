using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P83_Remove_Duplicates_from_Sorted_List {
        public ListNode DeleteDuplicates(ListNode head) {
            if (head == null) return null;
            ListNode Dummy = new ListNode(head.val + 1);
            Dummy.next = head;

            int hold = Dummy.val;
            ListNode current = head;
            ListNode previous = Dummy;
            while (current != null) {
                if (hold == current.val) {
                    previous.next = current.next;
                    current = current.next;
                }
                else {
                    hold = current.val;
                    previous = current;
                    current = current.next;
                }
            }
            return head;
        }
    }
}
