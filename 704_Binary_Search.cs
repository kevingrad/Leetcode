/*
704. Binary Search

Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    
    // Params: sorted array nums, desired int target
    // Returns index of target int if it exists in nums, else returns -1
    public int Search(int[] nums, int target) {
        // Initialize left, right, middle indices
        int leftIndex = 0;
        int rightIndex = nums.Count() - 1;
        int mid;
        int curVal;
        
        // Binary search cuts the array in half on each iteration,
        // evaluating the middle index's value. 
        while (leftIndex <= rightIndex) {
            mid = (leftIndex + rightIndex) / 2;
            curVal = nums[mid];
            // Three possible options until the while criteria is not hit:
                // 1. Current index value matches target. Return current index.
                // 2. Current index value is greater than target.
                // 3. Current index value is less than target.
            
            if (curVal == target) {
                return mid;
            }
            else if (curVal > target) {
                rightIndex = mid - 1;
            }
            else if (curVal < target) {
                leftIndex = mid + 1;
            }
        }
        
        // target doesn't exist in array, while loop exited
        return -1;
    }
}
