namespace Leetcode.CSharp.Solutions {
    public class P448_Find_All_Numbers_Disappeared_in_an_Array {
        //no external space 
        public IList<int> FindDisappearedNumbers(int[] nums) {

            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) {
                    nums[index] *= -1;
                }
            }
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > 0) {   // not processed
                    result.Add(i + 1);
                }
            }
            return result;
        }

        public IList<int> FindDisappearedNumbers2(int[] nums) {
            bool[] counter = new bool[nums.Length + 1];
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                counter[nums[i]] = true;
            }
            for (int i = 1; i < counter.Length; i++) {
                if (!counter[i]) {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
