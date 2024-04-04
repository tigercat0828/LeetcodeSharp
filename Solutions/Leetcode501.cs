using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions;
public class Leetcode501 {
    Dictionary<int, int> dict = [];
    public int[] FindMode(TreeNode root) {
        List<int> modes = [];
        PreOrder(root);
        int maxNum = 0;
        foreach (var item in dict) {
            maxNum = Math.Max(maxNum, item.Value);
        }

        foreach (var item in dict) {
            if (item.Value == maxNum) {
                modes.Add(item.Key);
            }
        }
        return modes.ToArray();
    }
    private void PreOrder(TreeNode root) {
        if (dict.ContainsKey(root.val)) {
            dict[root.val]++;
        }
        else {
            dict.Add(root.val, 1);
        }
        if (root.left != null) {
            PreOrder(root.left);
        }
        if (root.right != null) {
            PreOrder(root.right);
        }
    }
}
