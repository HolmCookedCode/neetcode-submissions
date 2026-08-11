public class Solution {
    public bool hasDuplicate(int[] nums) {
        // visited set
        HashSet<int> set = new HashSet<int>();

        // loop through array
        foreach (int num in nums)
        {
        // If set contains num
            if (set.Contains(num))
            {
                return true;
            }
            else 
            {
                set.Add(num);
            }
        }
        return false;
    }
}