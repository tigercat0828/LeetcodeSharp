using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class P206_Reverse_Linked_List {

    // iteration version
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode previous = null!;
        ListNode next = null!;
        while (current != null) {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        head = previous;
        return head;
    }
    // recursive
    public ListNode ReverseList2(ListNode node) {
        if (node == null || node.next == null) {
            return node;
        }
        ListNode last = ReverseList2(node.next);
        Console.WriteLine(last.val);
        node.next.next = node;
        node.next = null;
        return last;
    }

    // use O(n) extra space
    public ListNode ReverseList3(ListNode head) {
        if (head == null) {
            return null;
        }
        List<int> tmp = new List<int>();
        ListNode current = head;
        while (current != null) {
            tmp.Add(current.val);
            current = current.next;
        }
        ListNode newhead = new ListNode(tmp[0]);
        for (int i = 1; i < tmp.Count; i++) {
            ListNode newNode = new ListNode(tmp[i], newhead);
            newhead = newNode;
        }
        return newhead;
    }
}
