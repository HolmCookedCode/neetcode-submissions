public class Solution {
    public bool hasDuplicate(int[] nums) {
        // Set
        HashSet<int> set = new HashSet<int>();

        // Move through
        foreach(int num in nums) {
            // Check set, return true if duplicate
            if (set.Contains(num)) {
                return true;
            }
            else {
                set.Add(num);
            }
        }

        // return false
        return false;
    }
}