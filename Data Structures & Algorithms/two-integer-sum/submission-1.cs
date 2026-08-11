public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> visited = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++) {
        int current = nums[i];
        int match = target - current;
        if (visited.ContainsKey(match)) return new int[] { visited[match], i };
        visited[nums[i]] = i;
    }

    return new int[] { -1, -1 };
    }
}
