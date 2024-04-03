namespace Leetcode.CSharp.Solutions {
    // Successful Pairs of Spells and Potions
    public class Leetcode2300 {
        // naive approach
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
            int[] result = new int[spells.Length];
            int i = 0;
            foreach (var spell in spells) {
                var succ = potions.Select(v => v * spell).Where(n => n >= success).Count();
                result[i++] = succ;
            }
            return result;
        }

    }
}

/*
Input: spells = [5,1,3], potions = [1,2,3,4,5], success = 7
Output: [4,0,3]
Explanation:
- 0th spell: 5 * [1,2,3,4,5] = [5,10,15,20,25]. 4 pairs are successful.
- 1st spell: 1 * [1,2,3,4,5] = [1,2,3,4,5]. 0 pairs are successful.
- 2nd spell: 3 * [1,2,3,4,5] = [3,6,9,12,15]. 3 pairs are successful.
Thus, [4,0,3] is returned.
 */
