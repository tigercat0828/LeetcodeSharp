namespace LeetcodeSharp.Solutions {
    public class P21_Merge_Two_Sorted_Lists {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }

        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

            if (list2 == null) {
                return list1;
            }
            if (list1 == null) {
                return list2;
            }

            // dummy node for easy logic
            ListNode head = new ListNode(0);
            ListNode last = head;

            while (list1 != null && list2 != null) {
                if (list1.val <= list2.val) {
                    last.next = new ListNode(list1.val, null);
                    list1 = list1.next;
                }
                else {
                    last.next = new ListNode(list2.val, null);
                    list2 = list2.next;
                }
                last = last.next;
            }
            // add the remain node into list
            if (list1 != null) {
                last.next = list1;
            }
            if (list2 != null) {
                last.next = list2;
            }
            return head.next;
        }
    }
}
