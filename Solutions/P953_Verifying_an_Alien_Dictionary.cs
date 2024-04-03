namespace Leetcode.CSharp.Solutions {
    public class P953_Verifying_an_Alien_Dictionary {
        int[] map = new int[26];
        public bool isAlienSorted(string[] words, string order) {
            for (int i = 0; i < order.Length; i++)
                map[order[i] - 'a'] = i;
            for (int i = 1; i < words.Length; i++)
                if (bigger(words[i - 1], words[i]))
                    return false;
            return true;
        }

        bool bigger(string s1, string s2) {
            int n = s1.Length, m = s2.Length;
            for (int i = 0; i < n && i < m; ++i)
                if (s1[i] != s2[i])
                    return map[s1[i] - 'a'] > map[s2[i] - 'a'];
            return n > m;
        }
    }
}

