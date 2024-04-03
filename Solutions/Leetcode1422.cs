namespace Leetcode.CSharp.Solutions;
public class Leetcode1422 {
    public int MaxScore(string s) {

        int length = s.Length;

        int[] zeroFromLeft = new int[length];
        int[] oneFromRight = new int[length];

        zeroFromLeft[0] = s[0] == '0' ? 1 : 0;
        for (int i = 1; i < length; i++) {
            zeroFromLeft[i] = zeroFromLeft[i - 1];
            if (s[i] == '0') {
                zeroFromLeft[i]++;
            }
        }
        oneFromRight[length - 1] = s[length - 1] == '1' ? 1 : 0;
        for (int i = length - 2; i >= 0; i--) {
            oneFromRight[i] = oneFromRight[i + 1];
            if (s[i] == '1') {
                oneFromRight[i]++;
            }
        }
        //Console.WriteLine(string.Join(", ", zeroFromLeft));
        //Console.WriteLine(string.Join(", ", oneFromRight));

        int max = int.MinValue;
        for (int i = 0; i < length - 1; i++) {
            max = Math.Max(max, zeroFromLeft[i] + oneFromRight[i + 1]);
        }

        return max;
    }
}
