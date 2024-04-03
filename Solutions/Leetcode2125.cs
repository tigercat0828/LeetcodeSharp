namespace Leetcode.CSharp.Solutions {
    public class Leetcode2125 {
        public int NumberOfBeams(string[] bank) {
            int[] lasers = new int[bank.Length];
            for (int i = 0; i < bank.Length; i++) {
                string bankStr = bank[i];
                for (int j = 0; j < bankStr.Length; j++) {
                    if (bankStr[j] != '0') {
                        lasers[i]++;
                    }
                }
            }

            // List<int> laserList = lasers.Where(x => x > 0).ToList();
            List<int> laserList = new(bank.Length);
            for (int i = 0; i < lasers.Length; i++) {
                if (lasers[i] > 0)
                    laserList.Add(lasers[i]);
            }
            //----------------------------------------------------------

            int beams = 0;
            for (int i = 1; i < laserList.Count; i++) {

                beams += laserList[i] * laserList[i - 1];
            }
            return beams;
        }
    }
}
