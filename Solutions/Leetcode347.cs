namespace Leetcode.CSharp.Solutions;
public class Leetcode347 {
    // value : [-10000, +10000]
    public int[] TopKFrequent(int[] nums, int k) {
        int[] count = new int[20001];
        int maxFreq = nums.Length;
        for (int i = 0; i < nums.Length; i++) {
            count[nums[i] + 10000]++;
        }
        PriorityQueue<int, int> heap = new();    // min heap
        List<int> result = [];
        bool[] visited = new bool[20001];
        for (int i = 0; i < nums.Length; i++) {
            if (visited[nums[i] + 10000]) continue; // has already visited the element, skip to reduce heap operation
            heap.Enqueue(nums[i], maxFreq - count[nums[i] + 10000]);    // cause PQ in C# is min heap
            visited[nums[i] + 10000] = true;
        }
        for (int i = 0; i < k; i++) {
            result.Add(heap.Dequeue());
        }
        return [.. result];
    }
}
