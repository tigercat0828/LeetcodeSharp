namespace Leetcode.CSharp.Solutions {
    public class Leetcode649 {
        public string PredictPartyVictory(string senate) {
            Queue<int> radiants = new();
            Queue<int> dires = new();
            int count = senate.Length;
            for (int i = 0; i < senate.Length; i++) {
                if (senate[i] == 'R') radiants.Enqueue(i);
                if (senate[i] == 'D') dires.Enqueue(i);
            }
            while (dires.Any() && radiants.Any()) {

                int R = radiants.Dequeue();
                int D = dires.Dequeue();
                if (R < D) {    // R can kill D's right
                    radiants.Enqueue(R + count);
                }
                else {
                    dires.Enqueue(D + count);
                }
            }
            if (radiants.Any()) return "Radiant";
            else return "Dire";
        }
    }
}
