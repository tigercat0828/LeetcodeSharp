namespace Leetcode.CSharp.Solutions {
    public class P1678_Goal_Parser_Interpretation {
        public string Interpret(string command) {
            // G, (), (al);
            string result = "";
            int i = 0;
            while (i != command.Length) {
                if (command[i] == 'G') {
                    result += "G";
                    i++;
                }
                else if (command[i] == '(') {

                    if (command[i + 1] == ')') {
                        result += "o";
                        i += 2;
                    }
                    else if (command[i + 1] == 'a') {
                        result += "al";
                        i += 4;
                    }
                }
            }
            return result;
        }
    }
}

