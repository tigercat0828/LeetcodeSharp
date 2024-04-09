namespace LeetcodeSharp.Solutions {
    public class P63_Unique_Paths_II {
        const int OBSTACLE = -1;
        // O (row x col)
        public int UniquePathsWithObstacles(int[][] obstacleGrid) {
            int row = obstacleGrid.Length;
            int col = obstacleGrid[0].Length;

            // edge case 
            if (obstacleGrid[row - 1][col - 1] == 1 || obstacleGrid[0][0] == 1) {
                return 0;
            }
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (obstacleGrid[i][j] == 1) {
                        obstacleGrid[i][j] = OBSTACLE;
                    }
                }
            }

            for (int i = 0; i < col; i++) {
                if (obstacleGrid[0][i] == OBSTACLE) break;
                obstacleGrid[0][i] = 1;
            }
            for (int i = 0; i < row; i++) {
                if (obstacleGrid[i][0] == OBSTACLE) break;
                obstacleGrid[i][0] = 1;
            }

            for (int i = 1; i < row; i++) {
                for (int j = 1; j < col; j++) {
                    if (obstacleGrid[i][j] == OBSTACLE) continue;
                    int top = 0;
                    int left = 0;
                    if (obstacleGrid[i - 1][j] != OBSTACLE) {
                        top = obstacleGrid[i - 1][j];
                    }
                    if (obstacleGrid[i][j - 1] != OBSTACLE) {
                        left = obstacleGrid[i][j - 1];
                    }
                    obstacleGrid[i][j] = top + left;
                }
            }
            return obstacleGrid[row - 1][col - 1];
        }
    }
}
