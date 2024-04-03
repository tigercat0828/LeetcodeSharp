namespace LeetcodeSharp.Solutions;
public class Leetcode1160 {
    public int CountCharacters(string[] words, string chars) {
        int sum = 0;
        var mainDict = MakeDict(chars);
        foreach (var word in words) {
            bool canForm = true;
            var dict = MakeDict(word);

            for (int i = 0; i < word.Length; i++) {
                char c = word[i];
                if (!mainDict.ContainsKey(c) || mainDict[c] < dict[c]) {
                    canForm = false;
                    break;
                }
            }

            if (canForm) {
                sum += word.Length;
            }
        }
        return sum;
    }
    private Dictionary<char, int> MakeDict(string str) {
        Dictionary<char, int> dict = new();
        for (int i = 0; i < str.Length; i++) {
            char c = str[i];
            if (!dict.ContainsKey(c)) {
                dict.Add(c, 1);
            }
            else {
                dict[c]++;
            }
        }
        return dict;
    }
}
