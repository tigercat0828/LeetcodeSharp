namespace LeetcodeSharp.Solutions;
public class Leetcode2108 {
    public string FirstPalindrome(string[] words) {

        foreach (var word in words) {
            if (IsPalindrome(word)) return word;
        }
        return "";
    }
    private bool IsPalindrome(string word) {
        int n = word.Length - 1;
        for (int i = 0; i < word.Length / 2; i++) {
            //Console.WriteLine($"{word[i]} : {word[n-i]}");
            if (word[i] != word[n - i]) return false;
        }
        return true;
    }
}
