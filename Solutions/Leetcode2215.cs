namespace Leetcode.CSharp.Solutions {
    public class Leetcode2215 {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
            HashSet<int> A = nums1.ToHashSet();
            HashSet<int> B = nums2.ToHashSet();
            IList<IList<int>> result = new List<IList<int>> {
                A.Except(B).ToList(),
                B.Except(A).ToList()
            };
            return result;
        }

    }
}
