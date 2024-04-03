namespace LeetcodeSharp.Solutions; 
public class Leetcode54 {
    //  Right, Down, Left, Up
    static int[] dr = [0, 1, 0, -1];
    static int[] dc = [1, 0, -1, 0];

    public IList<int> SpiralOrder(int[][] matrix) {

        List<int> result = new List<int>();
        int row = matrix.Length;
        int col = matrix[0].Length;
        int count = row * col;

        bool[][] visited = new bool[row][];
        for (int i = 0; i < row; i++) visited[i] = new bool[col];

        int r = 0;
        int c = 0;
        int dir = 0;
        int current = 0;

        result.Add(matrix[r][c]);
        visited[r][c] = true;
        current++;

        while (current != count) {
            if (r + dr[dir] >= row || c + dc[dir] >= col || r + dr[dir] < 0 || c + dc[dir] < 0 ||
                visited[r + dr[dir]][c + dc[dir]]) {
                // make turn
                dir = (dir + 1) % 4;
            }
            r += dr[dir];
            c += dc[dir];

            result.Add(matrix[r][c]);
            visited[r][c] = true;
            current++;
        }
        return result;
    }

}
