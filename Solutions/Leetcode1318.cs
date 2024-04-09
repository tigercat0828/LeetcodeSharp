namespace LeetcodeSharp.Solutions;
public class Leetcode1318 { // Minimum Flips to Make a OR b Equal to c
    // straight forward
    public int MinFlips(int a, int b, int c) {

        string sA = ReverseString(Convert.ToString(a, 2));
        string sB = ReverseString(Convert.ToString(b, 2));
        string sC = ReverseString(Convert.ToString(c, 2));

        int length = Math.Max(sA.Length, sB.Length);
        length = Math.Max(length, sC.Length);
        int[][] bicode = new int[3][];
        for (int i = 0; i < 3; i++) bicode[i] = new int[length];

        for (int i = 0; i < sA.Length; i++) bicode[0][i] = sA[i] - '0';
        for (int i = 0; i < sB.Length; i++) bicode[1][i] = sB[i] - '0';
        for (int i = 0; i < sC.Length; i++) bicode[2][i] = sC[i] - '0';


        int bits = 0;
        for (int i = 0; i < length; i++) {
            int x = bicode[0][i];
            int y = bicode[1][i];
            int z = bicode[2][i];
            if ((x | y) == z) continue;
            // 01|0 10|0 > 1
            if ((x ^ y) == 1) bits += 1;
            else if (x == 0) bits += 1;  // 00|1
            else if (x == 1) bits += 2;  // 11|0
        }
        return bits;
    }
    private string ReverseString(string s) {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    // bit manipulation ...
}
