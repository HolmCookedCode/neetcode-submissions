public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // visited dictionary
        var visited = new Dictionary<int, int>();
        // target - current = complement
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (visited.ContainsKey(complement)) {
                return new int[] { visited[complement], i};
            }
            else {
                visited.Add(nums[i], i);
            }
        }

        return new int[] {-1, -1};
    }
}
