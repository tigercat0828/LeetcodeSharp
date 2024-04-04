namespace LeetcodeSharp.Common;
public class ListNode {
    public ListNode next;
    public int val;
    private int v;
    private ListNode head;

    public ListNode(int v) {
        this.v = v;
    }

    public ListNode(int v, ListNode head) {
        this.v = v;
        this.head = head;
    }
}
