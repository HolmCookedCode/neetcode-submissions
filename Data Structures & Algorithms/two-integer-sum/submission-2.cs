public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // visited dict
        Dictionary<int,int> visited = new Dictionary<int,int>();

        // Move through
        for (int i = 0; i < nums.Length; i++) {
            // target - current = complement
            int complement = target - nums[i];
            // if visited contains complement
            if (visited.ContainsKey(complement)) {
                // return [complement, current]
                return new int[] {visited[complement], i};
            }
            else {
                visited.Add(nums[i], i);
            }
        }

        return new int[] {-1, -1};
    }
}
