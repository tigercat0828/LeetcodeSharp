namespace LeetcodeSharp.Solutions {
    public class P88_Merge_Sorted_Array {
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            int[] temp = new int[m];
            Array.Copy(nums1, temp, m);
            int i = 0;
            int j = 0;
            int t = 0;
            while (i != m && j != n) {
                if (temp[i] <= nums2[j]) {
                    nums1[t] = temp[i];
                    i++;
                    t++;
                }
                else if (temp[i] > nums2[j]) {
                    nums1[t] = nums2[j];
                    j++;
                    t++;
                }
            }
            while (i != m) {
                nums1[t] = temp[i];
                i++;
                t++;
            }
            while (j != n) {
                nums1[t] = nums2[j];
                j++;
                t++;
            }
            //Console.WriteLine(string.Join('-', nums1));
        }
    }
}
