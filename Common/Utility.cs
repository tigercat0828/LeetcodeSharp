namespace LeetcodeSharp.Common; 
public static class Utility {
    public static int[] RandomArray(int count, int min, int max) {
        int[] array = new int[count];
        Random random = new Random();
        for (int i = 0; i < count; i++) {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }
    public static void PrintArray<T>(List<T> list) {
        Console.WriteLine(string.Join(string.Empty, list));
    }
    public static int[][] RandomMatrix(int row, int col, int min, int max) {
        int[][] matrix = new int[row][];
        for (int i = 0; i < row; i++) matrix[i] = new int[col];
        Random random = new Random();
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                matrix[i][j] = random.Next(min, max + 1);
            }
        }
        return matrix;
    }
    public static void PrintMatrix(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i++)
            Console.WriteLine("[" + string.Join(", ", matrix[i]) + "]");
    }
    public static void PrintMatrix(bool[][] matrix) {
        for (int i = 0; i < matrix.Length; i++) {
            Console.Write("[");
            for (int j = 0; j < matrix[0].Length; j++) {

                Console.Write((matrix[i][j] ? 1 : 0) + ", ");
            }
            Console.WriteLine("]");
        }
    }
    public static int[][] ParseArray2D(string input) {
        string[] rowStrings = input.Trim('[', ']').Split(new string[] { "],[" }, StringSplitOptions.None);

        int rowCount = rowStrings.Length;
        int[][] jaggedArray = new int[rowCount][];

        for (int i = 0; i < rowCount; i++) {
            jaggedArray[i] = rowStrings[i].Split(',').Select(int.Parse).ToArray();
        }

        return jaggedArray;
    }
}