namespace Leetcode.CSharp.Solutions {
    public class P941_Valid_Mountain_Array {
        public bool ValidMountainArray(int[] arr) {

            if (arr.Length <= 2) return false;
            if (arr[0] >= arr[1]) return false; // must increase at begin

            bool isIncreasing = true;

            for (int i = 2; i < arr.Length; i++) {

                if (arr[i - 1] == arr[i]) {  // strictly increase or decrease
                    return false;
                }

                if (isIncreasing) {  // increasing
                    if (arr[i - 1] > arr[i]) {
                        isIncreasing = false;
                    }
                }
                else {              // decreasing
                    if (arr[i - 1] < arr[i]) {
                        return false;
                    }
                }
            }
            return !isIncreasing;
        }
    }
}
