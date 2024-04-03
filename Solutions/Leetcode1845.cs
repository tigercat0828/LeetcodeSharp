namespace Leetcode.CSharp.Solutions;
public class Leetcode1845 {
    public class SeatManager {
        int customerNum;
        public SeatManager(int n) {
            customerNum = 0;
        }

        public int Reserve() {
            customerNum++;
            return customerNum;
        }

        public void Unreserve(int seatNumber) {
            customerNum--;
        }
    }

}
