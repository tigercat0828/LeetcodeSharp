namespace Leetcode.CSharp.Solutions {
    public class Leetcode2225 {
        class Player {
            public int ID;
            public int win;
            public int lose;
            public Player(int iD, int win, int loser) {
                ID = iD;
                this.win = win;
                this.lose = loser;
            }
        }
        public IList<IList<int>> FindWinners(int[][] matches) {


            Dictionary<int, Player> matchInfo = [];
            foreach (var match in matches) {
                int winner = match[0];
                int loser = match[1];
                if (!matchInfo.ContainsKey(winner)) {
                    matchInfo.Add(winner, new Player(winner, 0, 0));
                }
                if (!matchInfo.ContainsKey(loser)) {
                    matchInfo.Add(loser, new Player(loser, 0, 0));
                }
                matchInfo[winner].win++;
                matchInfo[loser].lose++;
            }
            List<IList<int>> answer = [[], []];

            foreach (var match in matchInfo) {
                var player = match.Value;
                if (player.lose == 0) {
                    answer[0].Add(player.ID);
                }
                if (player.lose == 1) {
                    answer[1].Add(player.ID);
                }
            }
            answer[0] = [.. answer[0].Order()];
            answer[1] = [.. answer[1].Order()];

            return answer;
        }
    }
}
