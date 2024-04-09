namespace LeetcodeSharp.Solutions;
public class Leetcode150 {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = [];
        List<string> operators = ["+", "-", "*", "/"];

        for (int i = 0; i < tokens.Length; i++) {
            if (!operators.Contains(tokens[i])) {
                int num = int.Parse(tokens[i]);
                stack.Push(num);
            }
            else {
                int operandB = stack.Pop();
                int operandA = stack.Pop();
                int result = 0;
                switch (tokens[i]) {
                    case "+":
                        result = operandA + operandB;
                        break;
                    case "-":
                        result = operandA - operandB;
                        break;
                    case "*":
                        result = operandA * operandB;
                        break;
                    case "/":
                        result = operandA / operandB;
                        break;
                }
                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}
