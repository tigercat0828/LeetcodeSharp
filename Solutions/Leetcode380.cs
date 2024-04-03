namespace Leetcode.CSharp.Solutions {
    public class Leetcode380 {
        class RandomizedSet {
            HashSet<int> set = [];
            Random random = new();
            public RandomizedSet() {

            }

            public bool Insert(int val) {
                if (set.Contains(val)) {
                    return false;
                }
                set.Add(val);
                return true;
            }

            public bool Remove(int val) {
                if (!set.Contains(val)) {
                    return false;
                }
                set.Remove(val);
                return true;
            }

            public int GetRandom() {
                int index = random.Next(0, set.Count);
                int i = 0;
                foreach (int val in set) {
                    if (i == index) return val;
                    i++;
                }
                return 0;
            }
        }
    }
}
