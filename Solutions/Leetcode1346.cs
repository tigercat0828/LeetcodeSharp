namespace Leetcode.CSharp.Solutions;
public class Leetcode1346 {
    public bool CheckIfExist(int[] arr) {
        Dictionary<float, float> dict = [];
        for (int i = 0; i < arr.Length; i++) {
            float val = arr[i];
            if (dict.ContainsKey(val)) {
                return true;
            }
            dict[val * 2] = val;
            dict[val / 2] = val;
        }
        return false;
    }
}
