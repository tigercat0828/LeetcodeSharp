namespace Leetcode.CSharp.Solutions {
    public class P1539_Kth_Missing_Positive_Number {
        // O(n)
        public int FindKthPositive(int[] arr, int k) {
            if (k < arr[0]) {
                return k;
            }
            for (int i = 0; i < arr.Length; i++) {
                if (k >= arr[i]) k++;
                else break;
            }
            return k;
        }

        // O(logn)
        public int FindKthPositive2(int[] arr, int k) {
            int left = 0;
            int right = 0;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (k <= arr[mid] - mid - 1) {
                    right = mid;
                }
                else {
                    left = mid + 1;
                }
            }
            return left + k;
        }
    }
}
