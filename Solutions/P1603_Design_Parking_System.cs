namespace LeetcodeSharp.Solutions {
    public class P1603_Design_Parking_System {
        public class ParkingSystem {
            enum CarType {
                Big = 1, Medium, Small
            }
            int[] carSlot = new int[4];
            int[] maxCarSlot = new int[4];

            public ParkingSystem(int big, int medium, int small) {
                maxCarSlot[(int)CarType.Big] = big;
                maxCarSlot[(int)CarType.Medium] = medium;
                maxCarSlot[(int)CarType.Small] = small;
            }
            public bool AddCar(int carType) {
                if (carSlot[carType] < maxCarSlot[carType]) {
                    carSlot[carType]++;
                    return true;
                }
                return false;
            }
        }
    }
}
