namespace Leetcode.CSharp.Solutions {
    public class Leetcode1658 {
        //
        public int MinOperations(int[] nums, int x) {
            int n = nums.Length;
            int[] prefix = new int[n];
            int[] suffix = new int[n];
            prefix[0] = nums[0];
            for (int i = 1; i < n; i++) {
                prefix[i] += prefix[i - 1] + nums[i];
            }
            suffix[0] = nums[n - 1];
            for (int i = 1; i < n; i++) {
                suffix[i] += suffix[i - 1] + nums[n - i - 1];
            }
            Console.WriteLine(string.Join(',', prefix));
            Console.WriteLine(string.Join(',', suffix));
            List<int> candidate = new();

            for (int i = 0; i < n; i++) {
                if (prefix[i] == x) {
                    candidate.Add(i + 1);
                    Console.WriteLine("whyA " + i + 1);
                    break;
                }
            }
            for (int i = 0; i < n; i++) {
                if (suffix[i] == x) {
                    candidate.Add(i + 1);
                    Console.WriteLine("whyB " + i + 1);
                    break;
                }
            }

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (prefix[i] + suffix[j] == x) {
                        candidate.Add(i + j + 2);
                        Console.WriteLine("whyC " + i + j + 2);
                        goto BLOCK_A;
                    }
                }
            }
        BLOCK_A:
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (suffix[i] + prefix[j] == x) {
                        candidate.Add(i + j + 2);
                        Console.WriteLine("whyD " + i + j + 2);
                        goto BLOCK_B;
                    }
                }
            }
        BLOCK_B:
            if (candidate.Count == 0) return -1;
            return candidate.Min();

        }
    }
}
