public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
    var result = new List<List<int>>();

    Array.Sort(nums);

    // Move through
    for (int i=0; i < nums.Length-2; i++) {
        // if i > 0 and nums[i-1] == nums[i]
        if (i > 0 && nums[i - 1] == nums[i]) {
            continue;
        }
        // left = right of current
        int l = i + 1;
        // right = end
        int r = nums.Length - 1;
        // while left less than right
        while (l < r) {
            // sum = nums[i] + left + right
            int sum = nums[i] + nums[l] + nums[r];
            if (sum == 0)
            {
                List<int> sumList = new List<int> { nums[i], nums[l], nums[r] };
                bool alreadyAdded = result.Any(l => l.SequenceEqual(sumList));
                if (!alreadyAdded) result.Add(new List<int> { nums[i], nums[l], nums[r] });
                l++;
            }
            else if (sum > 0) r--;
            else l++;
        }
    }
    return result;
    }
}
