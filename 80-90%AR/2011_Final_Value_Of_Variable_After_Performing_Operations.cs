/*
There is a programming language with only four operations and one variable X:

++X and X++ increments the value of the variable X by 1.
--X and X-- decrements the value of the variable X by 1.
Initially, the value of X is 0.

Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.
*/

public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int ans = 0;
        foreach (string str in operations) {
            if (str[1] == '+') {
                ans += 1;
            }
            else {
                ans -= 1;
            }
        }
        return ans;
    }
}
