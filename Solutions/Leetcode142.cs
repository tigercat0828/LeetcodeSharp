namespace Leetcode.CSharp.Solutions;

/*
fast = 2 * slow     
a+b+c+b = 2 (a+b) 
a = c
----------------X-------|
        a        |       |b
                 |       |
                c|-------X
*/
public class Leetcode142 {

    public ListNode DetectCycle(ListNode head) {
        ListNode meet = FindMeetNode(head);
        if (meet == null) {
            return null;
        }
        ListNode current = head;
        while (current != null && meet != null) {
            current = current.next;
            meet = meet.next;
            if (current == meet) {
                return current;
            }
        }
        return null;
    }

    private ListNode FindMeetNode(ListNode head) {
        if (head == null) {
            return null;
        }
        ListNode fast = head;
        ListNode slow = head;
        while (fast != null && slow != null) {
            fast = fast.next?.next;
            slow = slow.next;
            if (fast == slow) {
                return fast;
            }
        }
        return null;
    }

    public ListNode DetectCycle2(ListNode head) {
        if (head == null) return null;
        ListNode current = head;
        List<ListNode> record = new List<ListNode>();
        record.Add(current);
        int count = 0;
        while (current != null) {
            current = current.next;
            if (record.Contains(current)) {
                return current;
            }
            record.Add(current);
            count++;
            if (count > 10001) {
                return null;
            }
        }
        return null;
    }
}
