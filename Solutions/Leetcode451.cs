using System.Text;

namespace Leetcode.CSharp.Solutions;
public class Leetcode451 {



    public string FrequencySort(string s) {
        Dictionary<char, int> letter = [];
        foreach (char ch in s) {
            if (!letter.ContainsKey(ch)) letter.Add(ch, 0);
            letter[ch]++;
        }
        List<KeyValuePair<char, int>> items = [];
        foreach (var item in letter) {
            items.Add(item);
        }
        items = [.. items.OrderByDescending(x => x.Value)];
        StringBuilder sb = new();
        foreach (var item in items) {
            for (int i = 0; i < item.Value; i++) {
                sb.Append(item.Key);
            }
        }
        return sb.ToString();
    }

}
