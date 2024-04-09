using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class P203_Remove_Linked_List_Elements {
        public ListNode RemoveElements(ListNode head, int val) {
            ListNode tmpHead = new ListNode(val + 1, head);     // different from param:val
            head = tmpHead;
            ListNode previous = head;
            ListNode current = head.next;

            while (current != null) {
                if (current.val == val) {
                    previous.next = current.next;
                    current = current.next;
                }
                else {
                    previous = current;
                    current = current.next;
                }
            }
            head = head.next;   // delete the temp head
            return head;
        }
    }
}
