using System.Text;

namespace LeetcodeSharp.Solutions;
public class Leetcode48 {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = [];
        foreach (var str in strs) {
            string encoded = Encode(str);
            if (!dict.ContainsKey(encoded)) {
                dict.Add(encoded, []);
            }
            else {
                dict[encoded].Add(str);
            }
        }
        List<IList<string>> result = [];
        foreach (var keyValue in dict) {
            result.Add(keyValue.Value);
        }

        return result;
    }
    private string Encode(string str) {
        int[] count = new int[26];
        for (int i = 0; i < str.Length; i++) {
            Console.Write(str[i]);
            count[str[i] - 'a'] += 1;
        }
        Console.WriteLine();
        StringBuilder sb = new();
        for (int i = 0; i < 26; i++) {
            char alphbet = (char)('a' + i);
            sb.Append(count[i] + alphbet);
        }
        return sb.ToString();
    }
}
