/*
Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.
*/
public class Solution {
    public int PivotIndex(int[] nums) {
        int cur = 0;
        // int leftSum = 0;
        // int rightSum = 0;
        while (cur < nums.Length) {
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < cur; i++) {
                leftSum += nums[i];
            }
            for (int j = cur + 1; j < nums.Length; j++) {
                rightSum += nums[j];
            }
            if (leftSum == rightSum) {
                return cur;
            }
            cur++;
        }
        return -1;
    }
}
