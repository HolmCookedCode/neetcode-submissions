public class Solution {
    public int Search(int[] nums, int target) {
            // left
    int l = 0;
    // right
    int r = nums.Length - 1;

    // while left < right
    while (l <= r)
    {
        int m = l + (r - l) / 2;

        if (nums[m] == target) return m;
        if (target > nums[m]) {
            l = m + 1;
        }
        else {
            r = m - 1;
        }
    }

    return -1;
    }
}
