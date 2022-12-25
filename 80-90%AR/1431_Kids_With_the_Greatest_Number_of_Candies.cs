/*
There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

Note that multiple kids can have the greatest number of candies.
*/

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] ans = new bool[candies.Length];
        
        // get max val
        int max = 0;
        for (int i = 0; i < candies.Length; i++) {
            if (candies[i] > max) {
                max = candies[i];
            }
        }

        // fill bool array based on given condition
        for (int i = 0; i < candies.Length; i++) {
            if (candies[i] + extraCandies >= max) {
                ans[i] = true;
            }
            else ans[i] = false;
        }
        return ans;
    }
}
