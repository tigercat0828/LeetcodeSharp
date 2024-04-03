namespace Leetcode.CSharp.Solutions {
    public class Leetcode739 {
        struct Day(int index, int temp) {
            public int index = index;
            public int temp = temp;
        }
        public int[] DailyTemperatures(int[] temperatures) {
            Stack<Day> stack = [];
            stack.Push(new Day(0, temperatures[0]));
            int[] result = new int[temperatures.Length];
            for (int i = 1; i < temperatures.Length; i++) {
                while (temperatures[i] > stack.Peek().temp && stack.Count > 0) {
                    Day day = stack.Pop();
                    result[day.index] = i - day.index;
                }
                stack.Push(new Day(i, temperatures[i]));

            }
            return result;
        }
    }
}
