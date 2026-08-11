public class Solution {
    public bool hasDuplicate(int[] nums) {
    Dictionary<int, int> visited = new Dictionary<int, int>();

    foreach (int num in nums) {
        if (visited.ContainsKey(num)) return true;
        visited[num] = 1;
    }

    return false;
    }
}
