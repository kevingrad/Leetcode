public class Solution {
    public int[] RunningSum(int[] nums) {
        // Initialize running sum and array to hold incremental running sum vals
        int[] sumArray = new int[nums.Length];
        int sum = 0;

        // Loop through param array and add to sum and sumArray
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            sumArray[i] = sum;
        }
        
        return sumArray;
    }
}
