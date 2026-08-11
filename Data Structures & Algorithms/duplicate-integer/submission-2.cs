public class Solution {
    public bool hasDuplicate(int[] nums) {
    // establish set
    HashSet<int> visited = new HashSet<int>();

    // move through nums
    foreach (int num in nums) {
        if (visited.Contains(num)) return true;
        visited.Add(num);
    }

    return false;
    }
}
