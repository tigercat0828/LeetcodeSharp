namespace Leetcode.CSharp.Solutions {
    public class P1855_Maximum_Distance_Between_a_Pair_of_Values {
        // O(n^2) Brute force TLE
        public int MaxDistance3(int[] nums1, int[] nums2) {
            int maxDistance = 0;
            for (int i = 0; i < nums1.Length; i++) {
                for (int j = 0; j < nums2.Length; j++) {
                    if (i <= j && nums1[i] <= nums2[j]) {
                        maxDistance = Math.Max(maxDistance, j - i);
                    }
                }
            }
            return maxDistance;
        }
        // O(m+n) Two Pointer
        public int MaxDistance(int[] nums1, int[] nums2) {
            int i = 0;
            int j = 0;
            int maxDistance = 0;
            while (j < nums2.Length && i < nums1.Length) {
                if (i <= j && nums1[i] <= nums2[j]) {               // new candidate distance
                    maxDistance = Math.Max(j - i, maxDistance);
                    j++;                                            // try to increase distance
                }
                if (j < nums2.Length && nums1[i] > nums2[j]) {        // num1[i] have to be smaller
                    i++;
                }
                if (i > j) {                                        // j must be greater than i 
                    j++;
                }
            }
            return maxDistance;
        }
    }
}
