namespace LeetcodeSharp.Solutions;

public class Leetcode706 {
    public class MyHashMap {
        int[] dict = new int[1000001];

        public MyHashMap() {
            Array.Fill(dict, -1);
        }

        public void Put(int key, int value) {
            dict[key] = value;
        }

        public int Get(int key) {
            return dict[key];
        }

        public void Remove(int key) {
            dict[key] = -1;
        }
    }
}