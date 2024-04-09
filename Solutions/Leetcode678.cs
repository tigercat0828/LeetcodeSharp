using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSharp.Solutions; 
public class Leetcode678 {
    public bool CheckValidString(string s) {
        Stack<char> stack = [];
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                stack.Push('(');
            }
            else if (s[i] == ')'){
                bool t = stack.Count > 0 && stack.Peek() == '(' || stack.Peek() == '*';
                stack.Push(')');
                if(t) {
                    stack.Pop();
                    stack.Pop();
                }
            }
        }
        return stack.Count == 0;
    }
}
