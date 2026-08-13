public class Solution {
    public int Search(int[] nums, int target) {
        // if only one number, is it target? Return that
        if (nums.Length == 1) 
        {
            if (nums[0] == target) 
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        // left as start
        int l = 0;
        // right as end
        int r = nums.Length - 1;

        // while l < r
        while (l <= r)
        {
            // mid point is calculated, left + (right - left) / 2
            int m = l + (r - l) / 2;
            // if target = mid, return middle
            if (target == nums[m])
            {
                return m;
            } 
            // is target higher or lower than mid?
            // if higher
            else if (target > nums[m])
            {
                // left becomes mid + 1
                l = m + 1;
            }
            // if lower
            else 
            {
                // right becomes mid - 1
                r = m - 1;
            }
        }
        return -1;
    }
}