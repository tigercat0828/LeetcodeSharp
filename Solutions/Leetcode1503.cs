namespace LeetcodeSharp.Solutions;
public class Leetcode1503 {
    // 1503. Last Moment Before All Ants Fall Out of a Plank
    class Ant {
        public int ID;
        public int Direction;
        public int Position;
        public static int TotalCount = 0;
        public Ant(int direction, int position) {
            Direction = direction;
            Position = position;
            ID = (char)('A' + TotalCount);
            TotalCount++;
        }
        public int Walk() {
            Position += Direction;
            return Position;
        }
        public void Turn() {
            Direction *= -1;
        }
        public int Dead() { // fall out of a plank
            return ID;
        }
    }

    public int GetLastMoment(int n, int[] left, int[] right) {
        int time = 0;
        int[,] AntsOnRoad = new int[n, 4];
        HashSet<int> livedAnt = new();
        Dictionary<int, Ant> dict = new();
        foreach (int antPos in left) {
            Ant ant = new(-1, antPos);
            AntsOnRoad[antPos, 0] = ant.ID;
            livedAnt.Add(ant.ID);
            dict.Add(ant.ID, ant);
        }
        foreach (int antPos in right) {
            Ant ant = new(1, antPos);
            AntsOnRoad[antPos, 0] = ant.ID;
            livedAnt.Add(ant.ID);
            dict.Add(ant.ID, ant);
        }
        while (livedAnt.Any()) {
            time++;
            foreach (var antID in livedAnt) {
                Ant ant = dict[antID];
                ant.Walk();
            }
        }



        return time;
    }
}
