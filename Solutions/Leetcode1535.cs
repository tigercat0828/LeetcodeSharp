namespace LeetcodeSharp.Solutions {
    // 1535 Find the Winner of an Array Game
    public class Leetcode1535 {

        public int GetWinner(int[] arr, int k) {
            if (k > arr.Length) {
                return arr.ToList().Max();
            }
            int winner = arr[0];
            int winTimes = 0;
            for (int i = 1; i < arr.Length; i++) {
                if (winner > arr[i]) {
                    winTimes++;
                }
                else { //winner < arr[i]
                    winner = arr[i];
                    winTimes = 1;
                }

                if (winTimes == k) return winner;
            }
            return winner; // error
        }
        public int GetWinner2(int[] arr, int k) {

            if (k > arr.Length) {
                return arr.ToList().Max();
            }
            // simulation the problem statement
            LinkedList<int> deque = new();
            Dictionary<int, int> dict = new();
            for (int i = 0; i < arr.Length; i++) {
                deque.AddLast(arr[i]);
                dict.Add(arr[i], 0);
            }
            bool isGameOver = false;
            int winner = -1;
            while (!isGameOver) {
                int A = deque.First.Value;
                int B = deque.First.Next.Value;
                deque.RemoveFirst();
                deque.RemoveFirst();
                if (A > B) {
                    dict[A]++;
                    deque.AddFirst(A);
                    deque.AddLast(B);
                    if (dict[A] == k) {
                        winner = A;
                        isGameOver = true;
                    }
                }
                else { // B > A
                    dict[B]++;
                    deque.AddFirst(B);
                    deque.AddLast(A);
                    if (dict[B] == k) {
                        winner = B;
                        isGameOver = true;
                    }
                }
            }
            return winner;
        }
    }

}
