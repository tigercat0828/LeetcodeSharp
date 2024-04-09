namespace LeetcodeSharp.Solutions {
    public class Leetcode1436 {
        public string DestCity(IList<IList<string>> paths) {

            Dictionary<string, string> map = new();
            for (int i = 0; i < paths.Count; i++) {
                map.Add(paths[i][0], paths[i][1]);
            }
            string current = paths[0][0];
            while (map.TryGetValue(current, out string next)) {
                current = next;
            }
            return current;
        }
    }
}
