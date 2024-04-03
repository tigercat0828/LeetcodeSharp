namespace Leetcode.CSharp.Solutions {
    public class P1768_Merge_Strings_Alternately {
        public string MergeAlternately(string word1, string word2) {
            int i = 0;
            int j = 0;
            string result = "";
            while (i != word1.Length || j != word2.Length) {
                if (i < word1.Length) {
                    result += word1[i++];
                }
                if (j < word2.Length) {
                    result += word2[j++];
                }
            }
            return result;
        }
    }
}
