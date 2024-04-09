namespace LeetcodeSharp.Solutions {
    // MyLinkedList
    public class P707_Design_Linked_List {
        class Node {
            public int data;
            public Node next;
            public Node(int data, Node next) {
                this.data = data;
                this.next = next;
            }
        }

        Node head;
        int count = 0;
        public P707_Design_Linked_List() {
            head = null;
            count = 0;
        }

        public int Get(int index) {
            if (head == null || index < 0 || index >= count) {
                return -1;
            }
            Node current = head;
            for (int i = 0; i < index; i++) {
                current = current.next;
            }
            return current.data;
        }

        public void AddAtHead(int val) {
            Node node = new Node(val, head);
            head = node;
            count++;
        }

        public void AddAtTail(int val) {
            if (head == null) {
                head = new Node(val, null);
                count++;
                return;
            }


            Node current = head;
            while (current.next != null) {
                current = current.next;
            }
            Node node = new Node(val, null);
            current.next = node;
            count++;
        }

        public void AddAtIndex(int index, int val) {
            if (index < 0 || index > count) {
                return;
            }
            if (index == 0 || head == null) {
                AddAtHead(val);
                return;
            }

            Node current = head;
            for (int i = 0; i < index - 1; i++) {
                current = current.next;
            }
            Node node = new Node(val, current.next);
            current.next = node;
            count++;
        }

        public void DeleteAtIndex(int index) {
            if (head == null || index < 0 || index >= count) {
                return;
            }
            if (index == 0) {
                head = head.next;
                count--;
                return;
            }
            Node current = head;
            Node previous = current;
            for (int i = 0; i < index; i++) {
                previous = current;
                current = current.next;
            }
            previous.next = current.next;
            count--;
        }
        public void Traversal() {
            for (int i = 0; i < count; i++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            string output = "";
            Node current = head;
            while (current != null) {
                output += current.data + " ";
                current = current.next;
            }
            Console.WriteLine(output);
        }
    }
}
