namespace LeetcodeSharp.Solutions {
    public class Leetcode881 {
        public int NumRescueBoats(int[] people, int limit) {
            Array.Sort(people);
            int left = 0;
            int right = people.Length;
            int boat = 0;
            while (left < right) {
                if (people[left] + people[right] < limit) {
                    left++;
                    right++;
                }
                else {
                    left++;
                }
                boat++;
            }
            return boat;
        }
    }
}
