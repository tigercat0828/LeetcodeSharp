namespace LeetcodeSharp.Solutions;
public class Leetcode1337 {
    class RowComparer : Comparer<RowSoldierPair> {
        public override int Compare(RowSoldierPair x, RowSoldierPair y) {
            if (x.soldier.CompareTo(y.soldier) != 0) {
                return x.soldier.CompareTo(y.soldier);
            }
            else if (x.rowIndex.CompareTo(y.rowIndex) != 0) { // row first
                return x.rowIndex.CompareTo(y.rowIndex);
            }
            else {
                return 0;
            }
        }
    }
    struct RowSoldierPair {
        public int rowIndex;
        public int soldier;
        public RowSoldierPair(int rowIndex, int soldier) {
            this.rowIndex = rowIndex;
            this.soldier = soldier;
        }
    }
    // O(mlogn + mlogm + k)
    public int[] KWeakestRows(int[][] mat, int k) {

        int mRows = mat.Length;
        int nCols = mat[0].Length;
        RowSoldierPair[] pairs = new RowSoldierPair[mRows]; // (rowIndex, soldier)

        // count civilan in each row O(mlogn)
        for (int i = 0; i < mRows; i++) {
            int index = SeachCivilianIndex(mat[i]);
            if (index != -1) {
                pairs[i] = new RowSoldierPair(i, index);    // index num soldier
            }
            else {
                pairs[i] = new RowSoldierPair(i, nCols);    // all soldier
            }
        }
        // select k weakest row
        Array.Sort(pairs, new RowComparer());

        int[] result = new int[k];  // O(k)
        for (int i = 0; i < k; i++) {
            result[i] = pairs[i].rowIndex;
        }

        return result;
    }

    // O(logn)
    private int SeachCivilianIndex(int[] row) {
        int left = 0;
        int right = row.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (row[mid] >= 1) {
                left = mid + 1;
            }
            else { // row[mid] < 1
                right = mid;
            }
        }
        if (row[left] >= 1) return -1;
        return left;
    }
}
