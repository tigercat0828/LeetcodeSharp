namespace Leetcode.CSharp.Solutions {
    public class P1356_Sort_Integers_by_The_Number_of_1_Bits {

        private static int CountOneBit(int num) {
            int ones = 0;
            while (num != 0) {
                ones += num & 1;
                num >>= 1;
            }
            return ones;
        }
        public int[] SortByBits(int[] arr) {
            Array.Sort(arr, new OnebitsFirst());
            return arr;
        }
        private class OnebitsFirst : IComparer<int> {
            public int Compare(int x, int y) {
                int xbit = CountOneBit(x);
                int ybit = CountOneBit(y);
                if (xbit.CompareTo(ybit) != 0) {
                    return xbit.CompareTo(ybit);
                }
                else {
                    return x.CompareTo(y);
                }
            }
        }
    }
}

