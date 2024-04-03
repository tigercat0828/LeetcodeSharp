namespace Leetcode.CSharp.Solutions;
public class Leetcode232 {
    public class MyQueue {
        private Stack<int> stackQueue;
        private Stack<int> stackTmp;
        public MyQueue() {
            stackQueue = [];
            stackTmp = [];
        }
        public void Push(int x) {
            // move element from queue to temp
            while (stackQueue.Count > 0) {
                int pop = stackQueue.Pop();
                stackTmp.Push(pop);
            }
            stackQueue.Push(x);
            // move element from temp to queue
            while (stackTmp.Count > 0) {
                int pop = stackTmp.Pop();
                stackQueue.Push(pop);
            }
        }
        public int Pop() {
            return stackQueue.Pop();
        }
        public int Peek() {
            return stackQueue.Peek();
        }
        public bool Empty() {
            return stackQueue.Count == 0;
        }
    }

}
