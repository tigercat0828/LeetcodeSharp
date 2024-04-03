namespace Leetcode.CSharp.Solutions;
public class Leetcode1291 {
    public IList<int> SequentialDigits(int low, int high) {
        const string numbers = "123456789";
        int s = 0;
        int d = digitNum(low);

        int current = int.Parse(numbers.Substring(s, d));

        List<int> result = [];
        while (current <= high) {
            if (s + d == 9) {
                s = -1;
                d++;
            }
            if (current >= low) {
                result.Add(current);
            }

            if (d == 10) {
                break;
            }
            current = int.Parse(numbers.Substring(++s, d));
        }

        return result;
    }
    private int digitNum(int num) {
        int d = 0;
        while (num != 0) {
            num /= 10;
            d++;
        }
        return d;
    }
}
