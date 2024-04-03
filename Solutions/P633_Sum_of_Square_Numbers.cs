using static System.Math;
namespace Leetcode.CSharp.Solutions {
    public class P633_Sum_of_Square_Numbers {
        // O(sqrt(c)logc) by sqrt()
        public bool JudgeSquareSum(int c) {

            if (IsSquare(c)) return true;
            int end = (int)Sqrt(c);
            for (int i = end; i >= 1; i--) {
                int target = c - i * i;
                if (IsSquare(target)) return true;
            }
            return false;
        }

        bool IsSquare(int num) {
            int sqrt = (int)Sqrt(num);  // O(logn)
            int sqaure = sqrt * sqrt;
            return sqaure == num;
        }

        // O(sqrt(c)) by Two-Pointer
        public bool JudgeSquareSum2(int c) {
            long left = 0;
            long right = (int)Sqrt(c);
            while (left <= right) {
                long current = left * left + right * right;
                if (current == c) return true;
                if (current < c) left++;
                else right--;
            }
            return false;
        }
    }
}
