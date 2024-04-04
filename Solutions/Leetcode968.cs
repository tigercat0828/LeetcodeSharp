using LeetcodeSharp.Common;

namespace LeetcodeSharp.Solutions {
    public class Leetcode968 {
        const int UNCOVERED = 0;
        const int CAMERA = 1;
        const int COVERED = 2;

        int cameraCount = 0;
        public int MinCameraCover(TreeNode root) {

            if (help(root) == 0) {
                cameraCount++;
            }
            return cameraCount;
        }
        public int help(TreeNode root) {
            if (root == null) return UNCOVERED;
            int left = help(root.left);
            int right = help(root.right);

            if (left == UNCOVERED || right == UNCOVERED) {
                cameraCount++;
                return CAMERA;
            }
            if (left == COVERED && right == COVERED) {
                return UNCOVERED;
            }
            // at least one camera
            else {
                return COVERED;
            }
        }
    }
}
