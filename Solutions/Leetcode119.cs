namespace LeetcodeSharp.Solutions;
public class Leetcode119 {
    public IList<int> GetRow(int rowIndex) {
        List<int> row2 = [1, 1];

        return NextRow(row2, 1, rowIndex);
    }
    public List<int> NextRow(List<int> row, int currentRowIndex, int rowIndex) {

        if (rowIndex == 0) {
            return [1];
        }

        if (currentRowIndex == rowIndex) {
            return row;
        }

        List<int> newRow = [1];          // space O(n)
        for (int i = 0; i < row.Count - 1; i++) {
            newRow.Add(row[i] + row[i + 1]);
        }
        newRow.Add(1);

        return NextRow(newRow, newRow.Count - 1, rowIndex);
    }
}
