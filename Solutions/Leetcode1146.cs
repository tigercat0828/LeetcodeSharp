namespace LeetcodeSharp.Solutions;
public class Leetcode1146 {

    public class SnapshotArray {    // list of dictionary
        int[] array;
        int snap;
        List<Dictionary<int, int>> history = [];
        public SnapshotArray(int length) {
            array = new int[length];
            for (int i = 0; i < length; i++) {
                history.Add([]);
            }
        }

        public void Set(int index, int val) {
            array[index] = val;
            if (history[index].ContainsKey(snap)) {
                history[index][snap] = val;
            }
            else {
                history[index][snap] = val;
            }
        }

        public int Snap() {
            snap++;
            return snap - 1;
        }

        public int Get(int index, int snap_id) {
            int id = snap_id;
            while (id >= 0) {
                if (history[index].ContainsKey(id)) {
                    return history[index][id];
                }
                id--;
            }
            return 0;
        }
    }

    public class SnapshotArray1 {    // one dictionary approach
        int snap = 0;
        Dictionary<(int version, int index), int> history;
        int[] array;
        public SnapshotArray1(int length) {
            array = new int[length];
            history = [];
        }

        public void Set(int index, int val) {
            array[index] = val;
            if (history.ContainsKey((snap, index))) {
                history[(snap, index)] = val;
            }
            else {
                history.Add((snap, index), val);
            }
        }

        public int Snap() {
            snap++;
            return snap - 1;
        }
        public int Get(int index, int snap_id) {
            int id = snap_id;
            while (id >= 0) {
                if (history.ContainsKey((id, index))) {
                    return history[(id, index)];
                }
                id--;
            }
            return 0;
        }
    }

    /**
     * Your SnapshotArray object will be instantiated and called as such:
     * SnapshotArray obj = new SnapshotArray(length);
     * obj.Set(index,val);
     * int param_2 = obj.Snap();
     * int param_3 = obj.Get(index,snap_id);
     */
}
