namespace LeetcodeSharp.Solutions;
public class Leetcode905
{
    public int[] SortArrayByParity(int[] nums)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                // swap
                (nums[i], nums[index]) = (nums[index], nums[i]);
                index++;
            }
        }
        return nums;
    }
}
