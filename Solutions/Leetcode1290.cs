using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode1290 {
    // bit manupulation O(n)
    public int GetDecimalValue(ListNode head) {
        int result = 0;
        ListNode current = head;
        while (current != null) {
            result <<= 1;
            result |= current.val;
            current = current.next;
        }
        return result;
    }

    // O(n) space and time
    public int GetDecimalValue2(ListNode head) {
        List<int> bits = [];
        ListNode current = head;
        while (current != null) {
            bits.Add(current.val);
            current = current.next;
        }
        int sum = 0;

        bits.Reverse();
        for (int i = 0; i < bits.Count; i++) {
            sum += bits[i] * (int)Math.Pow(2, i);
        }
        return sum;
    }
}
