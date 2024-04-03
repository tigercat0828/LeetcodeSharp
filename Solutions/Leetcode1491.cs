namespace Leetcode.CSharp.Solutions {
    public class Leetcode1491 {

        public double Average(int[] salary) {
            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            for (int i = 0; i < salary.Length; i++) {
                sum += salary[i];
                if (salary[i] > max) {
                    max = salary[i];
                }
                if (salary[i] < min) {
                    min = salary[i];
                }
            }
            sum -= max + min;
            double average = sum / (salary.Length - 2);
            return average;
        }
        public double Average2(int[] salary) {
            // one line with bulit-in function
            return (salary.Sum() - salary.Max() - salary.Min()) / (salary.Length - 2);
        }
    }
}
