namespace LeetcodeSharp.Solutions {
    public class Leetcode852 {
        // O(logn)
        public int PeakIndexInMountainArray(int[] array) {
            return SearchPeak(array, 0, array.Length - 1);
        }
        private int SearchPeak(int[] array, int start, int end) {
            if (start <= end) {
                int mid = start + (end - start) / 2;    // right and left neighbor
                int left = mid - 1;
                int right = mid + 1;
                if (array[left] < array[mid] && array[mid] > array[right]) {
                    return mid;
                }
                if (array[left] < array[mid] && array[mid] < array[right]) {    // peak on the end side
                    return SearchPeak(array, mid, end);
                }
                if (array[left] > array[mid] && array[mid] > array[right]) {    // peak on the start side
                    return SearchPeak(array, start, mid);
                }
            }
            return -1; // not a mountain
        }
        // O(n)
        public int PeakIndexInMountainArray2(int[] arr) {
            for (int i = 1; i < arr.Length - 1; i++) {
                int left = arr[i - 1];
                int mid = arr[i];
                int right = arr[i + 1];
                if (left < mid && mid > right) {
                    return i;
                }
            }
            return -1; // not a mountain
        }

    }
}
