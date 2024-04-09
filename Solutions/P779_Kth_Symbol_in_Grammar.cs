namespace LeetcodeSharp.Solutions {
    public class P779_Kth_Symbol_in_Grammar {

        // O(logn)
        public int KthGrammar(int n, int k) {
            // backthrough path
            List<char> stepList = new List<char>();
            while (k != 1) {
                if (k % 2 == 0) {
                    stepList.Add('R');
                }
                else {
                    stepList.Add('L');
                    k++;        // celling
                }
                k /= 2;
                //Console.WriteLine(k);
            }
            stepList.Reverse();
            // Console.WriteLine(string.Join(' ', stepList));
            bool current = false;
            foreach (var step in stepList) {
                if (step == 'R')
                    current = !current;
                /* if(step == 'L'){
                    keep same, do nothing
                 */
            }
            return current ? 1 : 0;
        }
        // out of memory limit
        public int KthGrammar2(int n, int k) {
            int[] array = new int[4] { 0, 1, 1, 0 };

            if (n <= 3) {
                return array[k - 1];
            }

            for (int i = 4; i <= n; i++) {
                array = Mirror(array);
            }
            return array[k - 1];
        }
        private int[] Mirror(int[] list) {
            int[] result = new int[list.Length * 2];
            Array.Copy(list, result, list.Length);
            list.Reverse();
            Array.Copy(list, 0, result, list.Length, list.Length);
            return result;
        }
    }
}
