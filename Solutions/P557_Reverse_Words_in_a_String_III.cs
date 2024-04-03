namespace Leetcode.CSharp.Solutions {
    public class P557_Reverse_Words_in_a_String_III {
        public string ReverseWords(string s) {
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++) {
                words[i] = ReverseString(words[i]);
            }

            return string.Join(' ', words);
        }

        private string ReverseString(string s) {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

    }
}
