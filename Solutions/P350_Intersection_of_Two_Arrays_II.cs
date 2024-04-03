namespace Leetcode.CSharp.Solutions {
    public class P350_Intersection_of_Two_Arrays_II {
        // O(nlogn)
        public int[] Intersect(int[] nums1, int[] nums2) {
            Array.Sort(nums1);
            Console.WriteLine(string.Join('-', nums1));
            Array.Sort(nums2);
            Console.WriteLine(string.Join('-', nums2));
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length) {
                if (nums1[i] == nums1[j]) {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }
                if (nums1[i] <= nums2[j]) {
                    i++;
                }
                else {
                    j++;
                }
            }
            return result.ToArray();
        }
        // O(n) with Dictionary

    }
}
