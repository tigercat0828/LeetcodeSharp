namespace Leetcode.CSharp.Solutions {
    public class P496_Next_Greater_Element_I {
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            // O(n) monotonic stack : value in stack should be increasing or decreasing
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums2.Length; i++) {
                while (stack.Count > 0 && stack.Peek() < nums2[i]) {
                    map.Add(stack.Pop(), nums2[i]);
                }
                stack.Push(nums2[i]);
            }
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++) {
                result[i] = map.GetValueOrDefault(nums1[i], -1);
            }
            return result;
        }

    }
}
