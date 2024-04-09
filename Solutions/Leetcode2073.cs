namespace LeetcodeSharp.Solutions;
public class Leetcode2073 {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int times = 0;
        int turn = -1;

        while (tickets[k] > 0) {
            turn = (turn + 1) % tickets.Length;
            if (tickets[turn] == 0) {
                continue;
            }
            tickets[turn]--;
            times++;
        }
        return times;
    }

}
