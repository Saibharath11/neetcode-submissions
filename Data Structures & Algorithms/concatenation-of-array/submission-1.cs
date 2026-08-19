public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int count = nums.Length;
        int[] values = new int[count*2];
        for(int i=0; i<count; i++)
        {
            values[i] = nums[i];
            values[i+count] = nums[i];
        }
        return values;
    }
}