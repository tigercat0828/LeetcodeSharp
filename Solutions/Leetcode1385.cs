namespace LeetcodeSharp.Solutions; 
public class Leetcode1385 {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int count = 0;
        for (int i = 0; i < arr1.Length; i++) {
            bool pass = true;
            for (int j = 0; j < arr2.Length; j++) {
                if (Math.Abs(arr1[i] - arr2[j]) <= d) {
                    pass = false;
                    break;
                }
            }
            if (pass) {
                count++;
            }
        }
        return count;
    }
}
