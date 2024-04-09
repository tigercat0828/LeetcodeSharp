using System.Text;

namespace LeetcodeSharp.Solutions {
    public class Leetcode443 {
        public int Compress(char[] chars) {
            char current = '\n';
            int count = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chars.Length; i++) {
                if (current != chars[i]) {
                    if (count > 1) {
                        sb.Append(count);
                    }
                    sb.Append(chars[i]);
                    current = chars[i];
                    count = 1;
                }
                else {
                    count++;
                }
            }
            if (count > 1) {
                sb.Append(count);
            }

            for (int i = 0; i < sb.Length; i++) {
                chars[i] = sb[i];
            }
            return sb.Length;
        }
    }
}
/*
["a","b","b","b","b","b","b","b","b","b","b","b","b"]
["a","b","1","2"].
 */
