namespace LeetcodeSharp.Solutions {
    public class P622_Design_Circular_Queue {
        int front;
        int rear;
        int capacity;
        int[] queue;
        public P622_Design_Circular_Queue(int k) {
            front = 0;
            rear = 0;
            capacity = k + 1;
            queue = new int[k + 1];
        }
        public bool EnQueue(int value) {

            if (IsFull()) {
                return false;
            }
            queue[rear] = value;
            rear = (rear + 1) % capacity;
            return true;
        }

        public bool DeQueue() {
            if (IsEmpty()) {
                return false;
            }
            front = (front + 1) % capacity;
            return true;
        }

        public int Front() {
            if (IsEmpty()) {
                return -1;
            }
            return queue[front];
        }

        public int Rear() {
            if (IsEmpty()) {
                return -1;
            }
            if (rear - 1 == -1) {
                return queue[capacity - 1];
            }
            else {
                return queue[rear - 1];
            }
        }

        public bool IsEmpty() {
            if (front == rear) {
                return true;
            }
            return false;
        }

        public bool IsFull() {
            if ((rear + 1) % capacity == front) {
                return true;
            }
            return false;
        }
    }
}
